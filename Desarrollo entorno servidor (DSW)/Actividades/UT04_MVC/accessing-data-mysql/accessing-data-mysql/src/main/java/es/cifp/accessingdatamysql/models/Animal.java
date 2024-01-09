package es.cifp.accessingdatamysql.models;

import es.cifp.accessingdatamysql.models.Clase;
import jakarta.persistence.*;
import jakarta.validation.constraints.Max;
import jakarta.validation.constraints.Min;
import jakarta.validation.constraints.NotBlank;
import jakarta.validation.constraints.NotNull;
import jakarta.validation.constraints.Size;


@Entity
@Table(name = "animal")
public class Animal {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private int id;

    @Column(name = "nombre")
    @NotBlank(message = "El nombre es obligatorio")
    @Size(min = 3, max = 15, message = "El nombre debe tener entre 3 y 15 caracteres")
    private String nombre;

    @Column(name = "vida_media")
    @NotNull(message = "La Vida Media es obligatoria")
    @Min(value = 0, message = "La Vida Media debe ser mayor o igual a 0")
    @Max(value = 600, message = "La Vida Media debe ser menor o igual a 600")
    private Integer vidaMedia;
    @Column(name = "extinto")
    @NotNull(message = "El campo Extinto es obligatorio")
    private Boolean extinto;

    @ManyToOne
    @JoinColumn(name = "clase_id")
    private Clase clase;


    // Constructores
    public Animal() {

    }
    public Animal(String nombre, Integer vidaMedia, Boolean extinto, Clase clase) {
        this.nombre = nombre;
        this.vidaMedia = vidaMedia;
        this.extinto = extinto;
        this.clase = clase;
    }
    // Getters y setters
    public int getId() {
        return id;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public Integer getVidaMedia() {
        return vidaMedia;
    }

    public void setVidaMedia(Integer vidaMedia) {
        this.vidaMedia = vidaMedia;
    }

    public Boolean getExtinto() {
        return extinto;
    }

    public void setExtinto(Boolean extinto) {
        this.extinto = extinto;
    }
}
