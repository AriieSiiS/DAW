package auth.mvc.test.repositories;

import auth.mvc.test.models.AnimalClass;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

@Repository
public interface AnimalClassRepository extends JpaRepository<AnimalClass, Long> {
}