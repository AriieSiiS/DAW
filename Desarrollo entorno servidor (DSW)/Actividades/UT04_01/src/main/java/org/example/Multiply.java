package org.example;
import java.util.Scanner;

public class Multiply {
    public static void x10 () {
        Scanner scanner = new Scanner(System.in);

        // Pedir al usuario que ingrese un número
        System.out.println("Por favor, ingresa un número: ");

        // Leer el número ingresado por el usuario
        int numeroIngresado = scanner.nextInt();

        // Imprimir el número ingresado
        System.out.println(numeroIngresado * 10);

        // Cerrar el objeto Scanner para liberar recursos
        scanner.close();
    }
}
