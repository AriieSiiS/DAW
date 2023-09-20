using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPP
{
    public struct People
    {
        public string name;
        public string surname;
        public decimal height;
    }
    internal class CSFunciones
    {
        public static int SolicitarNumeroPersonas()
        {
            int countPeople;
            Console.WriteLine("¿Cuántos alumnos hay en la clase?");
            while(!Int32.TryParse(Console.ReadLine(),out countPeople) || !(countPeople > 0))
                Console.WriteLine("Lo que has insertado no es un valor numerico valido");
            return countPeople;
        }
         public static void LeerDatosMuestra(People[] classrom)
         {

            for(int i=0;i<classrom.Length; i++)
            {
                Console.WriteLine("Introduce el nombre del {0}º alumno:",i+1);
                while (((classrom[i].name = Console.ReadLine())==" ") &&(classrom[i].name!=""))
                    Console.WriteLine("La cadena no puede estar vacía");
                Console.WriteLine("Introduce su apellido:");
                while(((classrom[i].surname=Console.ReadLine())==" ") && (classrom[i].surname==""))
                    Console.WriteLine("La cadena no puede estar vacía");
                Console.WriteLine("¿Cuánto mide el alumno?");
                while(!(decimal.TryParse(Console.ReadLine(),out classrom[i].height))||!(classrom[i].height<3)||!(classrom[i].height>0))
                    Console.WriteLine("El valor no se encuentra dentro de los parámetros requeridos");
            }
          }
         public static void MostrarDatosMuestra(People[] classrom)
          {
            foreach(People alumnado in classrom )
            {
                Console.WriteLine("Nombre:{0} {1} \tEstatura:{2:f2}",alumnado.name,alumnado.surname,alumnado.height);
            }
          }   
     }
}
