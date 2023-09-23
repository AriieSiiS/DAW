using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJE0601_4
{
    class CLines
    {
        private string ProductName { get; set; }
        private decimal InitialPrice { get; set; }
        private decimal FinalPrice { get; set; }

        public decimal GetInitialPrice()
        {
            return (this.InitialPrice);
        }
        public decimal GetFinalPrice()
        {
            return (this.FinalPrice);
        }


        public CLines(string name, decimal price)
        {
            this.ProductName = name;
            this.InitialPrice = price;
            this.FinalPrice = price;
        }

        public void ShowLine()
        {
            Console.WriteLine("\t{0}\t{1:F2}\t{2:F2}", this.ProductName, this.InitialPrice, this.FinalPrice);
        }

        public static string RequestProductName()
        {
            string myNewName = "";
            do
            {
                Console.Clear();
                Console.WriteLine("Introduce el nombre del producto a añadir a la lista de la compra (introduce 0 para finalizar): ");
                myNewName = Console.ReadLine();
                if (myNewName.Equals(""))
                {
                    Console.WriteLine("Nombre de producto vacío. Pulsa una tecla para probar de nuevo ...");
                    _ = Console.ReadKey();
                }
            } while (myNewName.Equals(""));
            return (myNewName);
        }
       

        public static decimal RequestProductPrice(string myProductName)
        {
            decimal myPrice=0m;
            do
            {
                Console.Clear();
                Console.Write("Introduce el precio del producto {0}: ", myProductName);
                if (!(decimal.TryParse(Console.ReadLine(),out myPrice)))
                {
                    myPrice = -1;
                    Console.WriteLine("Precio incorrecto. Pulsa una tecla para probar de nuevo ...");
                    _ = Console.ReadKey();
                }
            } while (!CMonetary.IsMonetary(myPrice));
            return (myPrice);
        }

        public void ChangeFinalPrice()
        {
            this.FinalPrice = 0;
        }

    }
}
