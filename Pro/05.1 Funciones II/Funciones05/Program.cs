namespace Ejercicio
{
    internal class Ejercicio
    {
        static void Main(String[] args)
        {
            int num;
            Console.WriteLine("Dime un numero entero");
            while (!(Int32.TryParse(Console.ReadLine(), out num)))
                Console.WriteLine("El número introducido no es válido");

            int NCifras = Funciones.NCifras(num);
            Console.WriteLine("El número de cifras que tiene {0} es {1}", num, NCifras);
        }
    }
}


