package auth.mvc.test.services;

import auth.mvc.test.models.User;
import auth.mvc.test.models.Role;
import auth.mvc.test.repositories.RoleRepository;
import auth.mvc.test.repositories.UserRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.security.core.userdetails.UserDetails;
import org.springframework.security.core.userdetails.UserDetailsService;
import org.springframework.security.core.userdetails.UsernameNotFoundException;
import org.springframework.security.crypto.bcrypt.BCryptPasswordEncoder;
import org.springframework.security.crypto.password.PasswordEncoder;
import org.springframework.stereotype.Service;
import auth.mvc.test.security.SecurityConfig;

import java.util.*;

@Service
public class UserService implements UserDetailsService {

    @Autowired
    private UserRepository userRepository;
    @Autowired
    private RoleRepository roleRepository;

    @Override
    public UserDetails loadUserByUsername(String username) throws UsernameNotFoundException {
        User user = userRepository.findByUserName(username);

        if (user == null) {
            throw new UsernameNotFoundException("Usuario no encontrado: " + username);
        }

        return org.springframework.security.core.userdetails.User
                .withUsername(username)
                .password(user.getPassword())
                .roles(user.getRoles().stream().map(Role::getName).toArray(String[]::new))
                .build();
    }
    public User createUser(String username, String password) {
        String encodedPassword = encodePassword(password);

        Role userRole = roleRepository.findByName("ROLE_USER");

        if (userRole == null) {
            throw new RuntimeException("El rol 'USER' no existe en la base de datos.");
        }

        User user = new User();
        user.setUserName(username);
        user.setPassword(encodedPassword);

        Set<Role> userRoles = new HashSet<>();
        userRoles.add(userRole);
        user.setRoles(userRoles);

        return userRepository.save(user);
    }

    private String encodePassword(String password) {
        PasswordEncoder encoder = new BCryptPasswordEncoder();
        return encoder.encode(password);
    }


}
