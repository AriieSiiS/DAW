package auth.mvc.test.controllers;

import org.springframework.security.access.prepost.PreAuthorize;
import org.springframework.security.core.Authentication;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;

import java.util.Arrays;
import java.util.List;

@Controller
public class AnimalController {

    @GetMapping("/animals")
    @PreAuthorize("hasRole('USER')")
    public String listAnimals(Model model) {
        // Lógica para recuperar y mostrar la lista de animales
        List<String> animals = Arrays.asList("León", "Águila", "Serpiente");
        model.addAttribute("animals", animals);

        return "animalList";    }
}