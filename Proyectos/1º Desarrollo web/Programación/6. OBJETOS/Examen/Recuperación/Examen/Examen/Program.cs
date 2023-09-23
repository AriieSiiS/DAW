using System;

namespace Examen
{
    internal class Ejercicio
    {
        static void Main(String[] args)
        {
            //inicializamos la lista de contactos
            List<Contacto> ContactosTelefono = new List<Contacto>();
            string nombre;
            string grupo;
            int número;
            bool almacenamiento = true;
            bool nombreEncontrado;
            bool continua;


            Agenda memoria = new Agenda(ContactosTelefono);

            bool salir = false;
            while (!salir)
            {
                Funciones.LeerMenú();
                int opcion;
                while (!Int32.TryParse(Console.ReadLine(), out opcion))
                    Console.WriteLine("Escribe un número válido");

                switch (opcion)
                {
                    case 1:
                        //añadir contacto
                        nombre = Contacto.PedirNombre(ContactosTelefono);
                        if (nombre != "")
                        {
                            grupo = Contacto.PedirGrupo();
                            número = Contacto.PedirNumero();
                            if (número != 0)
                            {
                                Contacto contacto = new Contacto(nombre, grupo, número, almacenamiento);
                                ContactosTelefono.Add(contacto);
                                Console.WriteLine("El contacto ha sido añadido de forma exitosa");
                            }
                            else
                                Console.WriteLine("El número no es válido");
                        }
                        Funciones.MostrarMensajeContinuar();
                        break;
                    case 2:
                        //mover a memoria
                        Console.WriteLine("Dime el nombre del contacto que quieres mover");
                        nombre = Console.ReadLine();
                        nombreEncontrado = memoria.ValidarContacto(nombre);
                        if (nombreEncontrado)
                        { 
                            continua = memoria.MoverAMemoria(nombre);
                            if (continua)
                                Console.WriteLine("Contacto movido con éxito");
                            else
                                Console.WriteLine("El contacto ya estaba en la Memoria");
                        }
                        else
                            Console.WriteLine("No existe ningún contacto con ese nombre");
                        Funciones.MostrarMensajeContinuar();
                        break;
                    case 3:
                        //mover contacto a SIM
                        Console.WriteLine("Dime el nombre del contacto que quieres mover");
                        nombre = Console.ReadLine();
                        nombreEncontrado = memoria.ValidarContacto(nombre);
                        if (nombreEncontrado)
                        {
                            continua = memoria.MoverASim(nombre);
                            if (continua)
                                Console.WriteLine("Contacto movido con éxito");
                            else
                                Console.WriteLine("El contacto ya estaba en la SIM");
                        }
                        else
                            Console.WriteLine("No existe ningún contacto con ese nombre");
                        Funciones.MostrarMensajeContinuar();
                        break;
                    case 4:
                        //modificar grupo
                        Console.WriteLine("Dime el nombre del contacto que quieres mover");
                        nombre = Console.ReadLine();
                        nombreEncontrado = memoria.ValidarContacto(nombre);
                        if (nombreEncontrado)
                        {
                            continua = memoria.ValidarMemoria(nombre);
                            if (!continua)
                            {
                                grupo = Contacto.PedirGrupo();
                                memoria.ModificarGrupo(nombre, grupo);
                                Console.WriteLine("Grupo cambiado con éxito");
                            }
                            else
                                Console.WriteLine("No se puede modificar un contacto que no esté en la SIM");
                        }
                        else
                            Console.WriteLine("No existe ningún contacto con ese nombre");
                        Funciones.MostrarMensajeContinuar();
                        break;
                    case 5:
                        //modificar telefono
                        Console.WriteLine("Dime el nombre del contacto que quieres mover");
                        nombre = Console.ReadLine();
                        nombreEncontrado = memoria.ValidarContacto(nombre);
                        if (nombreEncontrado)
                        {
                            continua = memoria.ValidarMemoria(nombre);
                            if (!continua)
                            {
                                número = Contacto.PedirNumero();
                                continua = memoria.ModificarTelefono(nombre, número);
                                Console.WriteLine("Telefono cambiado con exito");
                            }
                            else
                                Console.WriteLine("No se puede modificar un contacto que no esté en la SIM");
                        }
                        else
                            Console.WriteLine("No existe ningún contacto con ese nombre");
                        Funciones.MostrarMensajeContinuar();
                        break;
                    case 6:
                        //Mostrar contactos SIM
                        Agenda.ContactosSIM(ContactosTelefono);
                        Funciones.MostrarMensajeContinuar();
                        break;
                    case 7:
                        //mostrar contactos memoria
                        Agenda.ContactosMemoria(ContactosTelefono);
                        Funciones.MostrarMensajeContinuar();
                        break;
                    case 8:
                        salir = true;
                        Console.WriteLine("Saliendo de la aplicación...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, ingresa un número válido."); Funciones.MostrarMensajeContinuar();
                        break;
                }
            }
        }
    }
}

