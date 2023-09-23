using System;

namespace Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crea una nueva lista de clientes
            ClientsList clientsList = new ClientsList();

            int option = 0;
            do
            {
                Functions.ReadMenuOptions();
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        string name = Clients.RequestUserName();
                        string surname = Clients.RequestUserName();
                        Clients newClient = new Clients(name, surname);
                        clientsList.clientList.Add(newClient);
                        break;
                    case 2:
                        Clients.FindClient(clientsList); 
                        break;
                    case 3:
                        Clients.ShowClients(clientsList);
                        break;
                    case 4:
                        Clients.DeleteClient(clientsList);
                        break;
                    case 0:
                        Console.WriteLine("Saliendo del programa");
                        break;
                    default:
                        Console.WriteLine("Opción inválida");
                        break;
                }

            } while (option != 0);


        }
    }
}
