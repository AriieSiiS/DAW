using System;

namespace CompleteMachine
{
    class CMachineLines
    {
        private static readonly int MAXSTOCK = 10;
        private int Stock { get; set; }
        private decimal ProductPrice { get; set; }

        public CMachineLines()
        {
            this.Stock = 0;
            this.ProductPrice = 0m;
        }

        public void ShowLineMachine(int linePosition)
        {
            Console.WriteLine("\tPOS: P{0}\t\tStock: {1} \tPrecio: {2:F2}", linePosition.ToString("00"), this.Stock, this.ProductPrice);
        }

        public decimal ExtractElement(int selectedPosition, decimal MachineBalance)
        {
            decimal result = 0m;
            if (this.Stock>0)
            {
                if (this.ProductPrice <= MachineBalance)
                {
                    this.Stock--;
                    result = this.ProductPrice;
                    Console.WriteLine("Elemento extraído de la posición P{0}", selectedPosition.ToString("00"));
                    _ = Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Saldo insuficiente para comprar el producto de la posición P{0}", selectedPosition.ToString("00"));
                    Console.WriteLine("Saldo actual: {0:F2}", MachineBalance);
                    Console.WriteLine("Precio del producto: {0:F2}", this.ProductPrice);
                    _ = Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("No hay elementos que extraer en la posición P{0}", selectedPosition.ToString("00"));
                _= Console.ReadKey();
            }
            return (result);
        }

        public void FillLine()
        {
            Console.Clear();
            Console.WriteLine("Stock actual: {0}", this.Stock);
            Console.WriteLine("Precio actual: {0:F2}", this.ProductPrice);
            this.ReadNewStock();
            this.ReadNewPrice();
            Console.WriteLine("Datos cambiados.");
            Console.Write("Pulsa una tecla para volver a la máquina ...");
            _ = Console.ReadKey();
        }

        private void ReadNewStock()
        {
            bool finish = false;
            do
            {
                Console.Write("Introduce el nuevo stock: ");
                if (Int32.TryParse(Console.ReadLine(),out int myNewStock))
                {
                    if (myNewStock>=0)
                    {
                        if (myNewStock<=CMachineLines.MAXSTOCK)
                        {
                            finish = true;
                            this.Stock = myNewStock;
                        }
                    }
                }
                if (!finish)
                {
                    Console.Write("Stock incorrecto. Ponga una cantidad válida.\nPulsa una tecla para continuar ....");
                    _ = Console.ReadKey(true);
                }
            } while (!finish);

        }

        private void ReadNewPrice()
        {
            bool finish = false;
            do
            {
                Console.Write("Introduce el nuevo precio: ");
                if (decimal.TryParse(Console.ReadLine(), out decimal myNewPrice))
                {
                    if (CMonetary.IsMonetary(myNewPrice))
                    {
                        finish = true;
                        this.ProductPrice = myNewPrice;
                    }
                }
                if (!finish)
                {
                    Console.Write("Precio incorrecto. Ponga una cantidad válida.\nPulsa una tecla para continuar ....");
                    _ = Console.ReadKey(true);
                }
            } while (!finish);

        }

    }
}
