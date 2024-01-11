package com.example.demo.controllers;

import com.example.demo.models.Persona;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestParam;

import java.util.List;

@Controller

public class MainController {
    @GetMapping("/")
    public String saluda(Model model){
        model.addAttribute("saludo", "Hola mi gente!");
        return "index";
    }
    @GetMapping("/despedida")
    public String despide(Model model){
        model.addAttribute("despedida", "Adiós mi gente!");
        return "despedida";
    }

    @GetMapping("/felicita/{id}")
    public String felicita(Model model, @PathVariable int id,
    @RequestParam( value = "name", required = false, defaultValue = "amigo")
    String name, @RequestParam( value = "age", required = false, defaultValue = "0") int age) {

        model.addAttribute("id", id);
        model.addAttribute("name", name);
        model.addAttribute("age", age);
        return "felicita";
    }

    /*@GetMapping("/persona")
    public String muestraPersona(Model model){
        Persona p1 = new Persona(1, "Antonio", 24, "antonio@gmail.com");
        model.addAttribute("persona", p1);
        return "persona";
    }*/

    @GetMapping("/persona")
    public String mostrarTodasLasPersonas(Model model) {
        // Obtener la lista de personas y agregarla al modelo
        List<Persona> personas = Persona.getPersonas();
        model.addAttribute("personas", personas);

        return "mostrarPersonas";
    }
}

