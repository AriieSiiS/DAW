using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ejercicio
{
    struct Student
    {
        public string Name;
        public string Surname;
        public float Evaluation1;
        public float Evaluation2;
        public float Evaluation3;
    }
    internal class Functions
    {

        public const string Fichero01 = "..\\..\\..\\Fichero01.txt";

        public static List<Student> Data()
        {
            int response;
            bool keepgoing = true;
            List<Student> students = new List<Student>();
            while (keepgoing)
            {
                Console.Clear();
                Console.WriteLine("Escribe el nombre del alumno");
                string name = "";
                while (name == "")
                {
                    name = Console.ReadLine();
                    if (name == "")
                        Console.WriteLine("El nombre no puede estar vacio, introducelo de nuevo.");
                }
                Console.WriteLine("Escribe el apellido del alumno");
                string surname = "";
                while (surname == "")
                {
                    surname = Console.ReadLine();
                    if (surname == "")
                        Console.WriteLine("El apellido no puede estar vacio, introducelo de nuevo.");
                }

                float evaluation1;
                Console.WriteLine("Escribe la nota de la primera evaluación");
                while (!(float.TryParse(Console.ReadLine(), out evaluation1)) || evaluation1 < 0 || evaluation1 > 10)
                    Console.WriteLine("Introduce un número válido");

                float evaluation2;
                Console.WriteLine("Escribe la nota de la segunda evaluación");
                while (!(float.TryParse(Console.ReadLine(), out evaluation2)) || evaluation2 < 0 || evaluation2 > 10)
                    Console.WriteLine("Introduce un número válido");

                float evaluation3;
                Console.WriteLine("Escribe la nota de la tercera evaluación");
                while (!(float.TryParse(Console.ReadLine(), out evaluation3)) || evaluation3 < 0 || evaluation3 > 10)
                    Console.WriteLine("Introduce un número válido");
                Console.Clear();

                students.Add(new Student
                {
                    Name = name,
                    Surname = surname,
                    Evaluation1 = evaluation1,
                    Evaluation2 = evaluation2,
                    Evaluation3 = evaluation3
                });
                 
                Console.WriteLine("Escribe 0 para salir o cualquier otro número para añadir otro alumno");
                while (!(Int32.TryParse(Console.ReadLine(), out response)))
                    Console.WriteLine("Introduce un número válido");
                if (response == 1)
                    keepgoing = false;
            }
            return students;

        }

        public static void WriteFile(List<Student> students)
        {
            StreamWriter write = new StreamWriter(Fichero01, true);
            try
            {
                foreach (Student student in students)
                {
                    write.WriteLine(student.Name);
                    write.WriteLine(student.Surname);
                    write.WriteLine(student.Evaluation1);
                    write.WriteLine(student.Evaluation2);
                    write.WriteLine(student.Evaluation3);
                }
                write.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void ReadFile()
        {
            string name;
            string surname;
            float evaluation1;
            float evaluation2;
            float evaluation3;
            string line;
            StreamReader reader = new StreamReader(Fichero01, true);
            try
            {
                while (!reader.EndOfStream)
                {
                    name = reader.ReadLine();
                    surname = reader.ReadLine();
                    line = reader.ReadLine();
                    evaluation1 = float.Parse(line);
                    line = reader.ReadLine();
                    evaluation2 = float.Parse(line);
                    line = reader.ReadLine();
                    evaluation3 = float.Parse(line);
                    if (evaluation1 < 5 && evaluation2 < 5 && evaluation3 < 5)
                    {
                        Console.WriteLine($"El alumno {name} {surname} tiene de notas {evaluation1}, {evaluation2} y {evaluation3}");
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
