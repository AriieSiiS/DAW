package auth.mvc.test.controllers;

import auth.mvc.test.models.UserDto;
import auth.mvc.test.services.UserService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.validation.BindingResult;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.ui.Model;
@Controller
public class AuthController {
    @Autowired
    private UserService userService;
    @GetMapping("/login")
    public String showLoginForm() {
        return "login";
    }
    @GetMapping("/register")
    public String showRegisterForm(Model model) {
        model.addAttribute("user", new UserDto());
        return "register";
    }
    @PostMapping("/register")
    public String registerUser(@ModelAttribute("user") UserDto userDto, BindingResult result) {
        if (result.hasErrors()) {
            return "register";
        }
        userService.createUser(userDto.getUsername(), userDto.getPassword());
        return "redirect:/login";
    }
}
