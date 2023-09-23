using System;
using System.Collections.Generic;

namespace CompleteMachine
{
    class CMachine
    {
        private static readonly int MAXLINES = 20;

        private List<CMachineLines> ListMachineLines { get; set; }
        private decimal MachineBalance { get; set; }

        public CMachine()
        {
            ListMachineLines = new List<CMachineLines>();
            for (int counter = 0; counter < CMachine.MAXLINES; counter++)
            {
                ListMachineLines.Add(new CMachineLines());
            }
            this.MachineBalance = 0m;
        }


        public void StartMachine()
        {
            bool finish = false;
            do
            {
                this.ShowMachineStatus();
                this.ShowMachineInputOptions();
                finish = this.OptionSelected();
            } while (!finish);
        }


        public void ShowMachineStatus()
        {
            Console.Clear();
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("-            ESTADO DE LA MÁQUINA                          -");
            Console.WriteLine("------------------------------------------------------------");
            for (int lineCounter=1;lineCounter<=ListMachineLines.Count;lineCounter++)
            {
                this.ListMachineLines[lineCounter-1].ShowLineMachine(lineCounter);
            }
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("                                SALDO: {0:F2} €", this.MachineBalance);
            Console.WriteLine("------------------------------------------------------------");
        }

        public void ShowMachineInputOptions()
        {
            Console.WriteLine("  Introduce:");
            Console.WriteLine("      - Una posición (P??)");
            Console.WriteLine("      - Un valor de moneda");
            Console.WriteLine("            0,01 0,02 0,05 0,10 0,20 0,50 1,00 2,00");
            Console.WriteLine("      - LLENAR para rellenar la máquina");
            Console.WriteLine("      - SALIR para apagar la máquina");
            Console.WriteLine("------------------------------------------------------------");
        }

        public bool OptionSelected()
        {
            bool finish = false;
            Console.Write("\t\tIntroduce la acción a realizar: ");
            string inputOption = Console.ReadLine();
            if (inputOption.Equals("SALIR"))
            {
                finish = true;
                Console.Clear();
                Console.WriteLine("Apagando la máquina ....");
                Console.WriteLine("Debe devolver {0:F2} €", this.MachineBalance);
            }
            else
            {
                if (inputOption.Equals("LLENAR"))
                {
                    // LLenar la máquina de productos y colocar su valor
                    this.FillMachine();
                }
                else
                {
                    if (CMonetary.IsCoin(inputOption))
                    {
                        // Añadir al saldo la moneda que se acaba de colocar
                        this.MachineBalance += Convert.ToDecimal(inputOption);
                    }
                    else
                    {
                        int selectedPosition = CMachine.IsPosition(inputOption);
                        if (!selectedPosition.Equals(-1))
                        {
                            // Queremos sacar un elemento de la posición dada, que es desde vista usuario
                            this.MachineBalance -= this.ListMachineLines[selectedPosition - 1].ExtractElement(selectedPosition, this.MachineBalance);
                        }
                        else
                        {
                            // La opción puesta no es nada de nada
                            Console.WriteLine("La opción introducida no es correcta.\nPulse un tecla para continuar ...");
                            _ = Console.ReadKey();
                        }
                    }
                }
            }
            return (finish);
        }


        private static int IsPosition (string value)
        {
            int result = -1;
            if (value.Length.Equals(3))
            {
                if (value[0].Equals('P'))
                {
                    if (Int32.TryParse(value.Substring(1,2), out int candidate))
                    {
                        if ((candidate>0) && (candidate<=CMachine.MAXLINES))
                        {
                            result = candidate;
                        }
                    }
                }
            }
            return(result);
        }


        private void FillMachine()
        {
            Console.Clear();
            Console.Write("Introduzca la posición que quiere rellenar (P??): ");
            string inputOption = Console.ReadLine();
            int selectedPosition = CMachine.IsPosition(inputOption);
            if (!selectedPosition.Equals(-1))
            {
                // En selectedPosition hay una posición pero de usuario
                this.ListMachineLines[selectedPosition - 1].FillLine();
            }
            else
            {
                Console.WriteLine("Posición introducida incorrecta.\nPulsa una tecla para volver a la máquina ...");
                _ = Console.ReadKey();
            }
        }

    }
}
