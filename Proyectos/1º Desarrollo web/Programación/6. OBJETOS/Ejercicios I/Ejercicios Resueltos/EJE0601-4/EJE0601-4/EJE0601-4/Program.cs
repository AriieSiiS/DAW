using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJE0601_4
{
    class Program
    {
        static void Main(string[] args)
        {
            CLinesList myList = new CLinesList();
            myList.BuyList();
            myList.ShowList();
            myList.GenerateFinalBuy();
            Console.Clear();
            Console.WriteLine("Listado FINAL de precios");
            _ = Console.ReadKey();
            myList.ShowList();
        }
    }
}
