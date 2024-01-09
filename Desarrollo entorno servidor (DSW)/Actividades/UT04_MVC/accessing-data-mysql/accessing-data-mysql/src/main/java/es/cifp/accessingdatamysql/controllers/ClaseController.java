package es.cifp.accessingdatamysql.controllers;

import es.cifp.accessingdatamysql.models.Animal;
import es.cifp.accessingdatamysql.models.Clase;
import es.cifp.accessingdatamysql.services.ClaseService;
import jakarta.validation.Valid;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.validation.BindingResult;
import org.springframework.web.bind.annotation.*;

import java.util.List;
import java.util.Optional;

@Controller
@RequestMapping("/Clase")
public class ClaseController {

    @Autowired
    private ClaseService claseService;

    // Mostrar lista de clases
    @GetMapping("/Listar")
    public String listClases(Model model) {
        model.addAttribute("clases", claseService.getAllClases());
        return "showClases";
    }

    // Mostrar detalles de una clase por ID
    @GetMapping("/{id}")
    public String specificClase(Model model, @PathVariable Long id) {
        Optional<Clase> clase = claseService.getClaseById(id);

        if (clase.isPresent()) {
            model.addAttribute("clase", clase.get());
            // Puedes agregar lógica adicional si es necesario
            return "detallesClase";
        } else {
            // Manejar el caso en que no se encuentre la clase con el ID dado
            return "error";
        }
    }

    // Crear una nueva clase (GET)
    @GetMapping("/Crear")
    public String createClaseForm(Model model) {
        model.addAttribute("clase", new Clase());
        return "createClase";
    }

    // Crear una nueva clase (POST)
    @PostMapping("/Crear")
    public String postCreateClase(@ModelAttribute("clase") Clase clase) {
        claseService.saveClase(clase);
        return "redirect:/Clases/Listar";
    }

    // Actualizar una clase por ID (GET)
    @GetMapping("/Actualizar/{id}")
    public String updateClaseForm(Model model, @PathVariable Long id) {
        Optional<Clase> clase = claseService.getClaseById(id);

        if (clase.isPresent()) {
            model.addAttribute("clase", clase.get());
            return "updateClase";
        } else {
            // Manejar el caso en que no se encuentre la clase con el ID dado
            return "error";
        }
    }

    // Actualizar una clase por ID (POST)
    @PostMapping("/Actualizar/{id}")
    public String postUpdateClase(@PathVariable Long id, @ModelAttribute("clase") Clase updatedClase) {
        Clase clase = claseService.updateClase(id, updatedClase);

        if (clase != null) {
            // Puedes agregar lógica adicional si es necesario
            return "redirect:/Clases/Listar";
        } else {
            // Manejar el caso en que no se encuentre la clase con el ID dado
            return "error";
        }
    }

    // Eliminar una clase por ID
    @PostMapping("/Eliminar/{id}")
    public String deleteClase(@PathVariable Long id) {
        claseService.deleteClase(id);
        return "redirect:/Clases/Listar";
    }
}