using System;
using System.Collections.Generic;

namespace Ejercicio
{
    internal class Ejercicio
    {
        static void Main(String[] args)
        {
            //pido los alumnos y las notas
            List<Student> students = Functions.Data();
            //escribo los datos en el fichero
            Functions.WriteFile(students);
            //leo el fichero con la condición del ejercicio
            Functions.ReadFile();
        }
    }
}


