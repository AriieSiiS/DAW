package com.example.demo.services;
import com.example.demo.models.Animal;
import com.example.demo.controllers.AnimalController;
import org.springframework.stereotype.Service;

import java.util.ArrayList;
import java.util.List;

@Service
public class AnimalService {

    private static List<Animal> listaAnimales = new ArrayList<>();

    static {
        listaAnimales.add(new Animal("León", 200, false));
        listaAnimales.add(new Animal("Elefante", 500, false));
        listaAnimales.add(new Animal("Delfín", 30, false));
    }

    public List<Animal> getListaAnimales() {
        return listaAnimales;
    }
    public static Animal obtenerAnimalPorId(int id) {
        for (Animal animal : listaAnimales) {
            if (animal.getId() == id) {
                return animal;
            }
        }
        return null;
    }

    public void addAnimal(Animal animal) {
        listaAnimales.add(animal);
    }

    public static void eliminarAnimal(Animal animal) {
        System.out.println("Eliminando animal: " + animal.getId());

        listaAnimales.remove(animal);
    }


    // Otros métodos de servicio relacionados con animales si es necesario
}
