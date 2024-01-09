package com.example.demo.models;
import java.util.ArrayList;
import java.util.List;

import jakarta.validation.constraints.Min;
import jakarta.validation.constraints.Max;
import jakarta.validation.constraints.NotNull;
import jakarta.validation.constraints.Size;
import jakarta.validation.constraints.NotBlank;

public class Animal {
    private static int contadorIds = 1;

    private int id;

    @NotBlank(message = "El nombre es obligatorio")
    @Size(min = 3, max = 15, message = "El nombre debe tener entre 3 y 15 caracteres")
    private String nombre;

    @NotNull(message = "La Vida Media es obligatoria")
    @Min(value = 0, message = "La Vida Media debe ser mayor o igual a 0")
    @Max(value = 600, message = "La Vida Media debe ser menor o igual a 600")
    private Integer vidaMedia;

    @NotNull(message = "El campo Extinto es obligatorio")
    private Boolean extinto;

    // Constructores
    public Animal() {
        this.id = contadorIds++;
    }

    public Animal(String nombre, Integer vidaMedia, Boolean extinto) {
        this.id = contadorIds++;
        this.nombre = nombre;
        this.vidaMedia = vidaMedia;
        this.extinto = extinto;
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
