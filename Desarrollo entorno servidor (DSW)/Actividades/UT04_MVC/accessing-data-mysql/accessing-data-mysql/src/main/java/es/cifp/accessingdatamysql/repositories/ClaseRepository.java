package es.cifp.accessingdatamysql.repositories;

import es.cifp.accessingdatamysql.models.Clase;
import org.springframework.data.jpa.repository.JpaRepository;
public interface ClaseRepository extends JpaRepository<Clase, Long> {
    // Métodos personalizados si son necesarios
}