package com.example.demo.controllers;
import com.example.demo.models.Animal;
import com.example.demo.services.AnimalService;
import jakarta.validation.Valid;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.validation.BindingResult;
import org.springframework.web.bind.annotation.*;
import org.springframework.ui.Model;

import java.util.List;

import static com.example.demo.services.AnimalService.obtenerAnimalPorId;

@Controller
@RequestMapping("/Animales")
public class AnimalController {

    @Autowired
    private AnimalService animalService;

    @GetMapping("/Listar")
    public String listAnimals(Model model) {
        List<Animal> animals = animalService.getListaAnimales();
        model.addAttribute("animales", animals);
        return "showAnimals";
    }

    @GetMapping("/{id}")
    public String specificAnimal(Model model, @PathVariable int id) {
        // Aquí deberías obtener el animal por su ID (puedes usar un servicio, base de datos, etc.)
        Animal animal = obtenerAnimalPorId(id);

        if (animal == null) {
            return "redirect:/Animales/Listar";
        }

        // Agregar el animal al modelo para que pueda ser utilizado en la vista
        model.addAttribute("animal", animal);

        // Devolver el nombre de la vista que mostrará los detalles del animal
        return "detallesAnimal";
    }

    @GetMapping("/Crear")
    public String createAnimal(Model model) {
        model.addAttribute("animal", new Animal());
        return "createAnimal";
    }

    @PostMapping("/Crear")
    public String postCreateAnimal(@Valid @ModelAttribute("animales") Animal animal,
                                   BindingResult bindingResult) {
        if(bindingResult.hasErrors()) {

            return "createAnimal";
        } else {
            animalService.addAnimal(animal);
            return "redirect:/Animales/Listar";
        }
    }

    @GetMapping("/Actualizar/{id}")
    public String updateAnimal(@PathVariable int id, Model model) {
        Animal animal = obtenerAnimalPorId(id);

        if (animal == null) {
            return "redirect:/Animales/Listar";
        }

        model.addAttribute("animal", animal);
        return "updateAnimal";
    }

    @PostMapping("/Actualizar/{id}")
    public String updateAnimal(@PathVariable int id,
                               @Valid @ModelAttribute("animal") Animal updatedAnimal,
                               BindingResult bindingResult) {
        if (bindingResult.hasErrors()) {
            System.out.println("Errores de validación:");
            // Manejo de errores de validación, puedes agregar lógica adicional si es necesario
            return "updateAnimal";
        } else {
            // Aquí deberías actualizar el animal en tu sistema (por ejemplo, en una base de datos)
            Animal existingAnimal = obtenerAnimalPorId(id);

            if (existingAnimal != null) {


                // Actualizar los atributos del animal existente con los nuevos valores
                existingAnimal.setNombre(updatedAnimal.getNombre());
                existingAnimal.setVidaMedia(updatedAnimal.getVidaMedia());
                existingAnimal.setExtinto(updatedAnimal.getExtinto());

                // Redirigir a la lista de animales después de la actualización
                return "redirect:/Animales/Listar";

            } else {
                return "redirect:/Animales/Listar";
            }
        }
    }

    @GetMapping("/Eliminar/{id}")
    public String showDeleteConfirmation(@PathVariable int id, Model model) {
        Animal animal = obtenerAnimalPorId(id);

        if (animal == null) {
            return "redirect:/Animales/Listar";
        }

        model.addAttribute("animal", animal);
        return "redirect:/Animales/Listar";
    }

    @PostMapping("/Eliminar/{id}")
    public String deleteAnimal(@PathVariable int id) {
        System.out.println("Deleting animal with ID: " + id);
        Animal animalToDelete = obtenerAnimalPorId(id);

        if (animalToDelete != null) {

            AnimalService.eliminarAnimal(animalToDelete);
            return "redirect:/Animales/Listar";
        } else {
            return "redirect:/Animales/Listar";
        }
    }




}
