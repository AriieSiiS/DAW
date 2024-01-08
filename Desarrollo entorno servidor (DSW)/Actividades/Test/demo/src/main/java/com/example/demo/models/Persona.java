package com.example.demo.models;
import java.util.ArrayList;
import java.util.List;

import jakarta.validation.constraints.Min;
import jakarta.validation.constraints.NotNull;
import jakarta.validation.constraints.Size;
import jakarta.validation.constraints.Email;


public class Persona {
    private static List<Persona> personas = new ArrayList<>();
    private int id;

    @NotNull(message = "El nombre no puede estar en blanco")
    @Size(min = 2, max = 14)
    private String name;

    @Min(value = 0, message = "La edad debe ser un número positivo")
    private int age;

    @Email(message = "El correo electrónico debe ser una dirección de correo válida")
    @NotNull(message = "El correo electrónico no puede estar en blanco")
    private String email;

    public Persona() {}

    public Persona (int id, String name, int age, String email) {
        this.id = id;
        this.name = name;
        this.age = age;
        this.email = email;
    }

    public int getId() { return id; }
    public void setId(int id) { this.id = id; }
    public String getName() { return name;}
    public void setName(String name) { this.name = name;}

    public int getAge() { return age; }
    public void setAge(int age) { this.age = age; }
    public String getEmail() { return email; }
    public void setEmail(String email) { this.email = email; }

    public static List<Persona> getPersonas() {
        return personas;
    }

    public static void agregarPersona(Persona persona) {
        personas.add(persona);
    }

}
