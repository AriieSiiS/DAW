package es.cifp.accessingdatamysql.services;

import es.cifp.accessingdatamysql.models.Clase;
import es.cifp.accessingdatamysql.repositories.ClaseRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.ArrayList;
import java.util.List;
import java.util.Optional;
@Service
public class ClaseService {

    @Autowired
    private ClaseRepository claseRepository;

    // Método para obtener todas las clases
    public List<Clase> getAllClases() {
        return claseRepository.findAll();
    }

    // Método para obtener una clase por ID
    public Optional<Clase> getClaseById(Long id) {
        return claseRepository.findById(id);
    }

    // Método para guardar una nueva clase
    public Clase saveClase(Clase clase) {
        return claseRepository.save(clase);
    }

    // Método para actualizar una clase existente
    public Clase updateClase(Long id, Clase updatedClase) {
        if (claseRepository.existsById(id)) {
            updatedClase.setId(Math.toIntExact(id));
            return claseRepository.save(updatedClase);
        } else {
            // Manejar el caso en que no se encuentre la clase con el ID dado
            // Puedes lanzar una excepción, retornar null o manejarlo de acuerdo a tus necesidades
            return null;
        }
    }

    // Método para eliminar una clase por ID
    public void deleteClase(Long id) {
        claseRepository.deleteById(id);
    }
}
