namespace Ejercicio
{
    internal class Ejercicio
    {
        static void Main(String[] args)
        {
            //darle la vuelta a nombre y apellidos
            bool check = false;
            string nombre = "";
            string apellidos = "";
            Console.WriteLine("Escribe tus apellidos y tu nombre");
            string apellidosnombre = Console.ReadLine();
            for (int i = 0; i < apellidosnombre.Length; i++)
            {
                if (apellidosnombre[i] == ',')
                {
                    check = true;
                    for (int j = i + 1; j < apellidosnombre.Length; j++)
                    {
                        nombre += apellidosnombre[j];
                    }
                    for (int x = 0; x <= i - 1; x++)
                    {
                        apellidos += apellidosnombre[x];
                    }
                }
            }
            if (check == true)
            {
                string nombrecompleto = nombre + ", " + apellidos;
                nombrecompleto = nombrecompleto.ToUpper();
                Console.WriteLine("\t{0}", nombrecompleto);
            }
            else
                Console.WriteLine("El nombre introducido no es válido");
        }
    }
}



