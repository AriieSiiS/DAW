using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Funciones
    {
        public static void LeerMenú()
        {
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Añadir contacto");
            Console.WriteLine("2. Mover contacto a la memoria");
            Console.WriteLine("3. Mover contacto a la SIM");
            Console.WriteLine("4. Modificar grupo");
            Console.WriteLine("5. Modificar teléfono");
            Console.WriteLine("6. Mostrar contactos SIM");
            Console.WriteLine("7. Mostrar contactos Memoria");
            Console.WriteLine("8. Salir del programa");
            Console.WriteLine("");
        }
        public static void MostrarMensajeContinuar()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Presione una tecla para continuar.");
            Console.ReadKey();
            Console.Clear();
        }


    }
}
