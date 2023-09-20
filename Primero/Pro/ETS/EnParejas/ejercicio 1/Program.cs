namespace EjercicioPP
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Necesarios 
            string msg;
            //Perdir número de alumnos 
            int countPeople=CSFunciones.SolicitarNumeroPersonas();
            //Crear la clase 
            People[] classroom = new People[countPeople];
            //Inicializamos la clase
            CSFunciones.LeerDatosMuestra(classroom);
            //Crear los tamaños 
            People[] tallStudents=new People[0];
            People[] smallStudents=new People[0];
            People[] equalAvgStudents=new People[0];
            //Crear y inicializar media
            decimal average = CSAlturas.CalcularMedia(classroom);
            //Inicializar tamaños
            CSAlturas.PersonasPorEncimaMedia(classroom, ref tallStudents, average);
            CSAlturas.PersonasPorDebajoMedia(classroom, ref smallStudents, average);
            CSAlturas.PersonasIgualMedia(classroom, ref equalAvgStudents, average);
            //Mostrar alumnos en total 
            CSFunciones.MostrarDatosMuestra(classroom);
            //Resetear pantalla
            Console.ReadKey();
            Console.Clear();
            //Mostrar menú para elegir opción
            Console.WriteLine("la media es de {0:f2}", average);
            Console.WriteLine("Dime una de las siguientes opciones:");
            Console.WriteLine("Por encima de la media = \"+\"");
            Console.WriteLine("Por debajo de la media = \"-\"");
            Console.WriteLine("Igual a la media = \"=\"");
            Console.WriteLine("Recuerde usar solo símbolos");
            //Elegir opción
            while (!((msg = Console.ReadLine()) == "+") && !(msg == "-") && !(msg == "="))
                Console.WriteLine("Solo puede ser los símbolos indicados arriba");
            //Mostrar por pantalla la elección
            CSAlturas.MostrarPersonas(msg,smallStudents,tallStudents,equalAvgStudents);
        }
    }
}