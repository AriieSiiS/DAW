package auth.mvc.test.models;
import lombok.Getter;
import lombok.Setter;
import jakarta.persistence.*;

import java.util.List;

@Entity
@Getter
@Setter
@Table(name = "animal_classes")
public class AnimalClass {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;

    @Column(nullable = false)
    private String className;

    @OneToMany(mappedBy = "animalClass", cascade = CascadeType.ALL)
    private List<Animal> animals;
}
