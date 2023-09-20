namespace Ejercicio
{
    internal class Ejercicio
    {
        static void Main(String[] args)
        {

            int año;
            Console.WriteLine("Dime un año");
            while (!(Int32.TryParse(Console.ReadLine(), out año)) || año < 0)
                Console.WriteLine("El número introducido no es válido");

            bool Bisiesto = Funciones.Bisiesto(año);
            Console.WriteLine(Bisiesto);
        }
    }
}


