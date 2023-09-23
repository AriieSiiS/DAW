using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{

    class ClientsList
    {
        /// <summary> Elemento en el que se almacena la lista de usuarios </summary>
        public List<Clients> clientList = new List<Clients>();
    }

    class Clients
    {
        /// <summary> Representa el nombre del cliente, no puede ser nulo. </summary>
        public string Name { get; set; }

        /// <summary> Representa el apellido del cliente, no puede ser nulo. </summary>
        public string SurName { get; set; }

        /// <summary> Representa el código del cliente que será un número correlativo. </summary>
        public int Cod { get; set; }

        /// <summary>Variable estática utilizada para generar códigos de cliente correlativos</summary>
        private static int nextCod = 1;

        public Clients(string name, string surname)
        {
            // Asigna los valores de nombre y apellido
            this.Name = name;
            this.SurName = surname;
            // Asigna el valor de nextCod a Cod y luego incrementa nextCod en 1
            this.Cod = nextCod++;
        }
        /// <sumary> Solicita por teclado el nombre del usuario </sumary>
        public static string RequestUserName()
        {
            string newUserName = "";
            do
            {
                Console.Clear();
                Console.WriteLine("Introduzca el nombre o apellido del usuario: ");
                newUserName = Console.ReadLine();
            } while (newUserName.Equals(""));
            Console.WriteLine("Cliente agregado correctamente.");
            return newUserName;
        }

        public static void ShowClients(ClientsList clientsList)
        {
            // Imprime los valores almacenados en la lista
            Console.Clear();
            Console.WriteLine("=== LISTA DE CLIENTES ===");
            foreach (Clients client in clientsList.clientList)
            {
                Console.WriteLine($"Código: {client.Cod} - Nombre: {client.Name} - Apellido: {client.SurName}");
            }
        }

        public static void FindClient(ClientsList clientsList)
        {
            Console.Write("Ingrese el nombre o apellido del cliente: ");
            string searchTerm = Console.ReadLine();

            if (clientsList.clientList.Any(client => client.Name.Equals(searchTerm) || client.SurName.Equals(searchTerm)))
            {
                Console.WriteLine($"El cliente {searchTerm} se encuentra en la lista.");
            }
            else
            {
                Console.WriteLine($"El cliente {searchTerm} no se encuentra en la lista.");
            }
        }

        public static void DeleteClient(ClientsList clientsList)
        {
            Console.Write("Ingrese el código del cliente que desea eliminar: ");
            if (int.TryParse(Console.ReadLine(), out int codToDelete))
            {
                Clients clientToDelete = clientsList.clientList.Find(client => client.Cod == codToDelete);
                if (clientToDelete != null)
                {
                    clientsList.clientList.Remove(clientToDelete);
                    Console.WriteLine("Cliente eliminado correctamente.");
                }
                else
                {
                    Console.WriteLine("Cliente no encontrado.");
                }
            }
            else
            {
                Console.WriteLine("Código inválido.");
            }
        }

    }


}
