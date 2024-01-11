package es.cifp.accessingdatamysql.services;

import es.cifp.accessingdatamysql.models.Animal;
import es.cifp.accessingdatamysql.repositories.AnimalRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.ArrayList;
import java.util.List;

@Service
public class AnimalService {
    @Autowired
    private final AnimalRepository animalRepository;

    public AnimalService(AnimalRepository animalRepository) {
        this.animalRepository = animalRepository;
    }
    public List<Animal> getListaAnimales() {
        return animalRepository.findAll();
    }

    public Animal obtenerAnimalPorId(Long id) {
        return animalRepository.findById(id).orElse(null);
    }

    public void saveAnimal(Animal animal) {
        animalRepository.save(animal);
    }


    public void eliminarAnimal(Long id) {
        animalRepository.deleteById(id);
    }


    // Otros métodos de servicio relacionados con animales si es necesario
}
