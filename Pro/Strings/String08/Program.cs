namespace Ejercicio
{
    class Ejercicio
    {
        static void Main(String[] args)
        {
            //tres intentos para escribir la contraseña
            int contador = 0;
            string contraseña = "Eureka";
            string frase = "";
            while (!(contador == 3) && (!(frase == contraseña)))
            {
                Console.WriteLine("Escribe la contraseña");
                frase = Console.ReadLine();
                contador++;
                if (contador == 3 && (!(frase == contraseña)))
                    Console.WriteLine("Has agotado tus tres intentos");
            }
        }
    }
}
