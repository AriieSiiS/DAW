package dsw.somosdeweb.GonSanManuelMyIkea.Services;


import dsw.somosdeweb.GonSanManuelMyIkea.Models.Roles;
import dsw.somosdeweb.GonSanManuelMyIkea.Models.User;
import dsw.somosdeweb.GonSanManuelMyIkea.Repositories.RoleRepository;
import dsw.somosdeweb.GonSanManuelMyIkea.Repositories.UserRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Lazy;
import org.springframework.context.annotation.Primary;
import org.springframework.security.core.GrantedAuthority;
import org.springframework.security.core.authority.SimpleGrantedAuthority;
import org.springframework.security.core.userdetails.UserDetails;
import org.springframework.security.core.userdetails.UserDetailsService;
import org.springframework.security.core.userdetails.UsernameNotFoundException;
import org.springframework.security.crypto.bcrypt.BCryptPasswordEncoder;
import org.springframework.security.crypto.password.PasswordEncoder;
import org.springframework.stereotype.Service;

import java.util.*;
import java.util.stream.Collectors;

@Primary
@Service
public class UserService implements UserDetailsService {

    @Lazy
    @Autowired
    private UserRepository userRepository;

    @Lazy
    @Autowired
    private RoleRepository roleRepository;

    @Lazy
    @Autowired
    private PasswordEncoder passwordEncoder;

    @Bean
    public PasswordEncoder passwordEncoder() {
        return new BCryptPasswordEncoder();
    }

    public User createUser(User newUser) {
        System.out.println(newUser.getUsername());
        System.out.println(newUser.getRoles().toString());

        newUser.setPassword(passwordEncoder.encode(newUser.getPassword()));

        if (newUser.getRoles() == null || newUser.getRoles().isEmpty()) {
            Set<Roles> defaultRoles = new HashSet<>();
            defaultRoles.add(getOrCreateRole("ROLE_USER"));
            newUser.setRoles(defaultRoles);
        }

        return userRepository.save(newUser);
    }


    private Collection<? extends GrantedAuthority> getAuthorities(Collection<Roles> roles) {
        return roles.stream()
                .map(role -> new SimpleGrantedAuthority(role.getRole()))
                .collect(Collectors.toList());
    }

    @Override
    public UserDetails loadUserByUsername(String userMail) throws UsernameNotFoundException {
        Optional<User> userOptional = userRepository.findByUserMail(userMail);
        User user = userOptional.orElseThrow(() -> new UsernameNotFoundException("Usuario no encontrado: " + userMail));

        return org.springframework.security.core.userdetails.User.builder()
                .username(user.getUserMail())
                .password(user.getPassword())
                .authorities(getAuthorities(user.getRoles()))
                .build();
    }

    public User loadUserDefault(String userMail) throws UsernameNotFoundException {
        Optional<User> userOptional = userRepository.findByUserMail(userMail);
        return userOptional.orElseThrow(() -> new UsernameNotFoundException("Usuario no encontrado: " + userMail));
    }

    public List<User> getAllUsers() {
        return userRepository.findAll();
    }

    public void saveRole(Roles role) {
        roleRepository.save(role);
    }

    public void deleteUserById(long id){userRepository.deleteById(id);}

    public Optional<User> getUserById(long id){return userRepository.findById(id);}

    public Roles getOrCreateRole(String roleName) {
        Optional<Roles> existingRole = roleRepository.findByRole(roleName);
        return existingRole.orElseGet(() -> roleRepository.save(new Roles(roleName)));
    }
}
