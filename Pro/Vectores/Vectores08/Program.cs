namespace Ejercicio
{
    class Ejercicio
    {
        static void Main(String[] args)
        {
            string[] Nombres = new string[4];
            decimal[] Sueldos = new decimal[12];
            decimal[] SueldoAcumulado = new decimal[4];
            decimal sueldo = 0;
            decimal sueldototal = 0;
            Console.WriteLine("Nombre de los empleados");
            for (int i = 0; i < Nombres.Length; i++)
            {
                Nombres[i] = Console.ReadLine();
            }
            Console.WriteLine("Sueldos de cada empleado");
            for (int i = 0; i < Sueldos.Length; i++)
            {
                while (!(Decimal.TryParse(Console.ReadLine(), out sueldo)))
                    Console.WriteLine("El número introducido no es válido");
                Sueldos[i] = sueldo;
                sueldototal += sueldo;
            }


            //Calcular sueldo acumulado
            decimal sueldoacumulado = 0;
            for (int i = 0; i < Nombres.Length; i++)
            {
                for (int j = 0; j < Sueldos.Length; j++)
                {
                    sueldoacumulado += Sueldos[j];
                    if (j == 3)
                    {
                        
                        sueldoacumulado = SueldoAcumulado[i];
                        sueldoacumulado = 0;
                       i++;
                    }
                    if (j == 6)
                    {
                        
                        sueldoacumulado = SueldoAcumulado[i];
                        sueldoacumulado = 0;
                        i++;
                    }
                    if (j == 9)
                    {
                        sueldoacumulado = SueldoAcumulado[i];
                        sueldoacumulado = 0;
                        i++;
                    }
                    if (j == 12)
                    {
                        sueldoacumulado = SueldoAcumulado[i];
                        sueldoacumulado = 0;
                    }
                }
            }
            //Total pagado
            Console.WriteLine("El sueldo total es {0}", sueldototal);
            decimal maximo = SueldoAcumulado[0];
            int contador = 0;
            //Nombre del operario con mayor sueldo
            for (int i = 0; i < SueldoAcumulado.Length; i++)
            {
                if (SueldoAcumulado[i] > maximo)
                {
                    maximo = SueldoAcumulado[i];
                    contador = i;
                }
                else
                {
                    if (maximo == SueldoAcumulado[0])
                    {
                        contador = 0;
                    }
                }
            }
            Console.WriteLine("El operario con mayor ingreso acumulado es {0}", Nombres[contador]);
        }
    }
}



