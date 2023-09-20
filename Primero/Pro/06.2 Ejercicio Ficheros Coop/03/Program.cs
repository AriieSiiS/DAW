using System;
using System.Collections.Generic;

namespace Ejercicio
{
    class Program03
    {
        static void Main(string[] args)
        {
            bool valor = Funciones.Existe();
            if (valor)
            {
                List<string> lineas = Funciones.GuardarLineas();
                List <string[]> listaDatos = Funciones.Splitearlo(lineas);
                //quitamos la primera linea que no nos interesa
                listaDatos.RemoveAt(0);
                Funciones.EscribirDatos(listaDatos);

            }
        }
    }
}
