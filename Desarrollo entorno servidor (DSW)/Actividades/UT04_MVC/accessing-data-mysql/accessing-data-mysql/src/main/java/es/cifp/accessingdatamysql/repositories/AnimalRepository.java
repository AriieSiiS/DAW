package es.cifp.accessingdatamysql.repositories;

import es.cifp.accessingdatamysql.models.Animal;
import org.springframework.data.jpa.repository.JpaRepository;

public interface AnimalRepository extends JpaRepository<Animal, Long> {
    // Puedes agregar consultas personalizadas si las necesitas
}