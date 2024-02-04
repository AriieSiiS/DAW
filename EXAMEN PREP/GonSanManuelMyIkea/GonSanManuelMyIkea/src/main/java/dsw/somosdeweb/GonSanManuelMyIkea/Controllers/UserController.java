package dsw.somosdeweb.GonSanManuelMyIkea.Controllers;

import dsw.somosdeweb.GonSanManuelMyIkea.Models.User;
import dsw.somosdeweb.GonSanManuelMyIkea.Services.UserService;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.security.access.prepost.PreAuthorize;
import org.springframework.security.core.Authentication;
import org.springframework.security.web.authentication.logout.SecurityContextLogoutHandler;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.*;

import java.util.List;
import java.util.Optional;
import java.util.stream.Collectors;

@Controller
public class UserController {

    private final UserService userService;
    private static final Logger logger = LoggerFactory.getLogger(UserController.class);

    public UserController(UserService userService) {
        this.userService = userService;
    }

    @GetMapping("/register")
    public String registrationForm(Model model) {
        model.addAttribute("user", new User());
        return "register";
    }

    @PostMapping("/register")
    public String registerUser(@ModelAttribute("user") User user) {
        logger.info("Registrando nuevo usuario: {}", user.getUsername());
        userService.createUser(user);
        logger.info("Usuario registrado exitosamente");
        return "redirect:/login";
    }

    @GetMapping("/login")
    public String loginPage() {
        logger.info("Accediendo a la página de inicio de sesión");
        return "login";
    }

    @GetMapping("/logout")
    public String logout(HttpServletRequest request, HttpServletResponse response, Authentication authentication) {
        if (authentication != null) {
            new SecurityContextLogoutHandler().logout(request, response, authentication);
        }
        return "redirect:/";
    }

    @PreAuthorize("hasAnyRole('ROLE_ADMIN')")
    @GetMapping("/usuarios/lista")
    public String userList(Model model, Authentication authentication) {
        String currentUsername = authentication.getName();
        List<User> users = userService.getAllUsers();

        List<User> filteredUsers = users.stream()
                .filter(user -> !user.getUserMail().equals(currentUsername))
                .collect(Collectors.toList());

        model.addAttribute("users", filteredUsers);
        return "usuarios/lista";
    }

    @PreAuthorize("hasAnyRole('ROLE_ADMIN')")
    @GetMapping("/usuarios/eliminar/{id}")
    public String deleteUser(@PathVariable long id, Authentication authentication) {
        String currentUsername = authentication.getName();
        Optional<User> userToDelete = userService.getUserById(id);

        if (!userToDelete.get().getUserMail().equals(currentUsername)) {
            userService.deleteUserById(id);
        }
        else {
            logger.error("ERROR: No se puede borrar el mismo usuario logueado!");
        }
        return "redirect:/usuarios/lista";
    }
}
