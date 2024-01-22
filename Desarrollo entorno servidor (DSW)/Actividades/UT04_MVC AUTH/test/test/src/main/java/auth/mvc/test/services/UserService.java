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
    @Autowired
    private PasswordEncoder passwordEncoder;
    @Override
    public UserDetails loadUserByUsername(String username) throws UsernameNotFoundException {
        User user = userRepository.findByUsername(username);

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
        // Encriptar la contraseña
        String encodedPassword = passwordEncoder.encode(password);

        // Recuperar el rol de la base de datos (suponiendo que "USER" es el nombre del rol)
        Role userRole = roleRepository.findByName("USER");

        // Si el rol no existe, podrías manejarlo según tus necesidades (lanzar una excepción, asignar un rol predeterminado, etc.)
        if (userRole == null) {
            throw new RuntimeException("El rol 'USER' no existe en la base de datos.");
        }

        User user = new User();
        user.setUserName(username);
        user.setPassword(encodedPassword);

        // Crear una lista de roles y asignarla al usuario
        Set<Role> userRoles = new HashSet<>();
        userRoles.add(userRole);
        user.setRoles(userRoles);

        // Guardar el usuario en la base de datos
        return userRepository.save(user);
    }


}
