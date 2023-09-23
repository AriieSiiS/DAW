namespace Ejercicio
{
    class Ejercicio
    {
        static void Main(String[] args)
        {
            int num1;
            int num2;
            int contador = 0;
            Console.WriteLine("Dime dos números");
            while (!int.TryParse(Console.ReadLine(), out num1) || (num1 < 1))
                Console.WriteLine("El número introducido no es correcto");
            while (!int.TryParse(Console.ReadLine(), out num2) || (num2 < 1))
                Console.WriteLine("El número introducido no es correcto");
            if (num1 > num2)
            {
                contador = num1 - num2;
                while (contador > 0)
                {
                    contador--;
                    Console.WriteLine("\t{0}", contador);
                }
                    
            }
            else
            {
                contador = num2 - num1;
                while (contador > 0)
                {
                    contador--;
                    Console.WriteLine("\t{0}", contador);
                }
                    
            }




        }
    }
}





