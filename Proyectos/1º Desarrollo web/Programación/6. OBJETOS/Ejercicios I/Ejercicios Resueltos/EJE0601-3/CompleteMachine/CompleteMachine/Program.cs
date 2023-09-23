using System;

namespace CompleteMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Default;
            Console.OutputEncoding = System.Text.Encoding.Default;
            CMachine myMachine = new CMachine();
            myMachine.StartMachine();
            Program.Bye();
        }

        public static void Bye()
        {
            Console.Write("Pulsa una tecla para finalizar ...");
            _ = Console.ReadKey(true);
        }

    }
}
