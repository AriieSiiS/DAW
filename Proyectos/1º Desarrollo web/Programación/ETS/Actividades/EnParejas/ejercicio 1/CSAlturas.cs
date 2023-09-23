using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPP
{
    
    internal class CSAlturas
    {
        public static decimal CalcularMedia(People[] classroom)
        {
            decimal average=0;
            foreach(People alumnado in classroom)
            {
                average+=alumnado.height;
            }
            average/=classroom.Length;
            Console.WriteLine(average);
            return average;
           
        }

        public static void PersonasPorEncimaMedia(People[] classroom,ref People[] tallStudents,decimal average)
        {
            int cont=0;
            foreach(People alumnado in classroom)
            {
                if(alumnado.height>average)
                {
                    Array.Resize(ref tallStudents,tallStudents.Length+1);
                    tallStudents[cont].height=alumnado.height;
                    tallStudents[cont].name=alumnado.name;
                    tallStudents[cont].surname=alumnado.surname;
                    cont++;
                }
            }

        }



        public static void PersonasPorDebajoMedia(People[] classroom, ref People[] smallStudents,decimal average)
        {
            int cont=0;
            foreach(People alumnado in classroom)
            {
                if(alumnado.height<average)
                {
                    Array.Resize(ref smallStudents,smallStudents.Length+1);
                    smallStudents[cont].height=alumnado.height;
                    smallStudents[cont].name=alumnado.name;
                    smallStudents[cont].surname=alumnado.surname;
                    cont++;
                }
            }
        }
        public static void PersonasIgualMedia(People[] classroom, ref People[] equalAvgStudents,decimal average)
        {
            int cont = 0;
            foreach(People alumnado in classroom)
            {
                if(alumnado.height==average)
                {
                    Array.Resize(ref equalAvgStudents,equalAvgStudents.Length+1);
                    equalAvgStudents[cont].height=alumnado.height;
                    equalAvgStudents[cont].name=alumnado.name;
                    equalAvgStudents[cont].surname=alumnado.surname;
                    cont++;
                }
            }
        }

        public static void MostrarPersonas(string msg,People[] smallStudents,People[] tallStudents,People[] equalAvgStudents)
        {
            if(msg=="+")
            {
                foreach(People alumnado in tallStudents)
                {
                    Console.WriteLine("Nombre:{0} {1} \tEstatura:{2:f2}",alumnado.name,alumnado.surname,alumnado.height);
                }
            }
            else if(msg=="-")
            {
                foreach(People alumnado in smallStudents)
                {
                    Console.WriteLine("Nombre:{0} {1} \tEstatura:{2:f2}",alumnado.name,alumnado.surname,alumnado.height);
                }
            }else
            {
                foreach(People alumnado in equalAvgStudents)
                {
                    Console.WriteLine("Nombre:{0} {1}",alumnado.name,alumnado.surname);
                }
            }
        } 
    }
}
