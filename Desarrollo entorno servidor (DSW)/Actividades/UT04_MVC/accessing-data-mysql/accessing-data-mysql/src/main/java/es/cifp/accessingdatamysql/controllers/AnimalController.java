package es.cifp.accessingdatamysql.controllers;

import es.cifp.accessingdatamysql.models.Animal;
import es.cifp.accessingdatamysql.services.AnimalService;
import jakarta.validation.Valid;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.validation.BindingResult;
import org.springframework.web.bind.annotation.*;

import java.util.List;


@Controller
@RequestMapping("/Animales")
public class AnimalController {

    @Autowired
    private AnimalService animalService;

    @GetMapping("/Listar")
    public String listAnimals(Model model) {
        List<Animal> animals = animalService.getListaAnimales();
        model.addAttribute("animal", animals);
        return "showAnimals";
    }

    @GetMapping("/Detalles/{id}")
    public String animalDetails(@PathVariable Long id, Model model) {
        Animal animal = animalService.obtenerAnimalPorId(id);

        if (animal != null) {
            model.addAttribute("animal", animal);
            return "detallesAnimal";
        } else {
            return "detallesAnimal";
        }
    }

    @GetMapping("/Crear")
    public String createAnimalForm(Model model) {
        model.addAttribute("animal", new Animal());
        return "createAnimal";
    }

    @PostMapping("/Crear")
    public String createAnimal(@Valid @ModelAttribute("animal") Animal animal,
                               BindingResult bindingResult) {
        if (bindingResult.hasErrors()) {
            // Si hay errores de validación, vuelve al formulario de creación
            return "createAnimal";
        } else {
            // Guarda el nuevo animal en la base de datos a través del servicio
            animalService.saveAnimal(animal);
            return "redirect:/Animales/Listar";
        }
    }

    @GetMapping("/Actualizar/{id}")
    public String showUpdateForm(@PathVariable int id, Model model) {
        // Obtener el animal existente por su ID
        Animal existingAnimal = animalService.obtenerAnimalPorId((long) id);

        // Agregar el animal al modelo
        model.addAttribute("animal", existingAnimal);

        // Devolver la vista del formulario de actualización
        return "updateAnimal";
    }

    @PostMapping("/Actualizar/{id}")
    public String updateAnimal(@PathVariable int id, @Valid @ModelAttribute("animal") Animal updatedAnimal,
                               BindingResult bindingResult, Model model) {
        if (bindingResult.hasErrors()) {
            // Manejar errores de validación, si es necesario
            return "updateAnimal";
        } else {
            // Obtener el animal existente por su ID
            Animal existingAnimal = animalService.obtenerAnimalPorId((long) id);

            if (existingAnimal != null) {
                // Actualizar los atributos del animal existente con los nuevos valores
                existingAnimal.setNombre(updatedAnimal.getNombre());
                existingAnimal.setVidaMedia(updatedAnimal.getVidaMedia());
                existingAnimal.setExtinto(updatedAnimal.getExtinto());

                // Guardar los cambios en el servicio (que persistirá los cambios en la base de datos)
                animalService.saveAnimal(existingAnimal);

                // Redirigir a la lista de animales después de la actualización
                return "redirect:/Animales/Listar";
            } else {
                // Manejar el caso en que no se encuentre el animal con el ID dado
                return "error"; // Puedes redirigir a una página de error o manejarlo según tus necesidades
            }
        }
    }


    @PostMapping("/Eliminar/{id}")
    public String deleteAnimal(@PathVariable Long id) {
        animalService.eliminarAnimal(id);
        return "redirect:/Animales/Listar";
    }

}
