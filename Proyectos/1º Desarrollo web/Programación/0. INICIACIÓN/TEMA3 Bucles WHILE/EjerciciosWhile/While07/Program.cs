namespace Ejercicio
{
    class Ejercicio
    {
        static void Main(String[] args)
        {
            int num1;
            int contador = 1;
            Console.WriteLine("Dime un número");
            while (!int.TryParse(Console.ReadLine(), out num1))
                Console.WriteLine("El número introducido no es correcto");
            do
            {
                Console.WriteLine("\t{0}", contador);
                contador++;
            }
            while (contador < num1);

        }
    }
}




