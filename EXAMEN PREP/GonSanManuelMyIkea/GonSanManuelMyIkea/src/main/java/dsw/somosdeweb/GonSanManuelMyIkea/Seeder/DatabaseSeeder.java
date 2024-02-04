package dsw.somosdeweb.GonSanManuelMyIkea.Seeder;

import dsw.somosdeweb.GonSanManuelMyIkea.Models.Roles;
import dsw.somosdeweb.GonSanManuelMyIkea.Models.User;
import dsw.somosdeweb.GonSanManuelMyIkea.Services.UserService;
import jakarta.annotation.PostConstruct;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Component;

import java.util.*;

@Component
public class DatabaseSeeder {
    private final UserService userService;

    @Autowired
    public DatabaseSeeder(UserService userService) {
        this.userService = userService;
    }

    @PostConstruct
    public void seedDatabase() {

        if (userService.getAllUsers().isEmpty()){
            seedUsuarios();
        }
    }

    private void seedUsuarios() {

        Roles userRole = userService.getOrCreateRole("ROLE_USER");
        if (userRole == null) {
            userRole = new Roles("ROLE_USER");
            userService.saveRole(userRole);
        }

        Roles managerRole = userService.getOrCreateRole("ROLE_MANAGER");
        if (managerRole == null) {
            managerRole = new Roles("ROLE_MANAGER");
            userService.saveRole(managerRole);
        }

        Roles adminRole = userService.getOrCreateRole("ROLE_ADMIN");
        if (adminRole == null) {
            adminRole = new Roles("ROLE_ADMIN");
            userService.saveRole(adminRole);
        }

        User admin = new User();
        admin.setUsername("admin");
        admin.setUserMail("admin@myikea.com");
        admin.setPassword("Pantalla1*");
        admin.setRoles(new HashSet<>(Arrays.asList(managerRole,adminRole)));
        userService.createUser(admin);

        User manager = new User();
        manager.setUsername("manager");
        manager.setUserMail("manager@myikea.com");
        manager.setPassword("Pantalla1*");
        manager.setRoles(new HashSet<>(Collections.singletonList(managerRole)));
        userService.createUser(manager);


        User user = new User();
        user.setUsername("user");
        user.setUserMail("user@myikea.com");
        user.setPassword("Pantalla1*");
        user.setRoles(new HashSet<>(Collections.singletonList(userRole)));
        userService.createUser(user);

    }


}
