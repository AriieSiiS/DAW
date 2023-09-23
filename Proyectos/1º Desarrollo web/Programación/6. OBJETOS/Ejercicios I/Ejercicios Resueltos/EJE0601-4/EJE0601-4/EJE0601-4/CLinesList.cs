using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJE0601_4
{
    class CLinesList
    {
        private List<CLines> myList;

        public CLinesList ()
        {
            this.myList = new List<CLines>();
        }

        public void BuyList()
        {
            bool finish = false;
            do
            {
                Console.Clear();
                string myNewName = CLines.RequestProductName();
                if (myNewName.Equals("0"))
                {
                    finish = true;
                }
                else
                {
                    decimal myNewPrice = CLines.RequestProductPrice(myNewName);
                    this.myList.Add(new CLines(myNewName, myNewPrice));
                    Console.WriteLine("Línea insertada.");
                    Console.WriteLine("Pulsa una tecla para introducir la siguiente ...");
                    _ = Console.ReadKey();
                }
            } while (!finish);
        }

        public void ShowList()
        {
            Console.Clear();
            Console.WriteLine("LISTA DE LA COMPRA");
            Console.WriteLine("-------------------------------------------");
            foreach (CLines myLine in this.myList)
            {
                myLine.ShowLine();
            }
            Console.WriteLine("-------------------------------------------");
            Console.Write("Pulsa una tecla para continuar ...");
            _ = Console.ReadKey();
        }

        public void GenerateFinalBuy()
        {
            int numberOfZeroPrice = this.myList.Count / 3;
            for (int currentZeroPrice = 0; currentZeroPrice< numberOfZeroPrice;currentZeroPrice++)
            {
                int myMinPosition = this.SearchMinPriceIndex();
                this.myList[myMinPosition].ChangeFinalPrice();
            }
        }

        private int SearchMinPriceIndex()
        {
            int myIndex = -1;
            int myPosition = 0;
            decimal myMin = 0;
            while(this.myList[myPosition].GetFinalPrice().Equals(0m))
            {
                myPosition++;
            }
            myIndex = myPosition;
            myMin = this.myList[myPosition].GetFinalPrice();
            for (;myPosition<myList.Count;myPosition++)
            {
                if (!this.myList[myPosition].GetFinalPrice().Equals(0m))
                {
                    if (this.myList[myPosition].GetInitialPrice() < myMin)
                    {
                        myIndex = myPosition;
                        myMin = this.myList[myPosition].GetInitialPrice();
                    }
                }
            }
            return (myIndex);
        }

    }
}
