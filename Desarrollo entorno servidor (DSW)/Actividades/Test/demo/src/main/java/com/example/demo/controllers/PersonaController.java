package com.example.demo.controllers;

import com.example.demo.models.Persona;
import jakarta.validation.Valid;
import org.springframework.stereotype.Controller;
import org.springframework.validation.BindingResult;
import org.springframework.web.bind.annotation.*;
import org.springframework.ui.Model;


@Controller
@RequestMapping("/persona")
public class PersonaController {

    @GetMapping("/crear")
    public String mostrarFormularioCreacion(Model model) {
        // Crear una instancia de Persona y agregarla al modelo
        model.addAttribute("persona", new Persona());
        return "crearPersona";
    }

    @PostMapping("/crear")
    public String procesarFormularioCreacion(@Valid @ModelAttribute("persona") Persona persona,
                                             BindingResult bindingResult) {
        if(bindingResult.hasErrors()) {
            //Modelo inválido
            return "crearPersona";
        } else {
            System.out.println("Nombre: " + persona.getName());
            Persona.agregarPersona(persona);
            return "redirect:/persona";
        }

    }
}
