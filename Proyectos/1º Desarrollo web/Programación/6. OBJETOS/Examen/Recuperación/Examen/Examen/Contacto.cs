using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Contacto
    {
        /// <summary> Nombre del contacto </summary>
        private string Nombre { get; set; }

        /// <summary> Grupo del contacto (familia, trabajo...) </summary>

        private string Grupo { get; set; }

        /// <summary> Telefono del contacto </summary>
        private int Telefono { get; set; }

        /// <summary> Lugar de almacenamiento del contacto (SIM o Memoria). Por defecto va en la SIM (true).</summary>
        private bool Almacenamiento { get; set; } //True = SIM / False = Memoria

        //Constructores
        public Contacto()
        {
        }
        public Contacto(string nombre, string grupo, int telefono, bool almacenamiento)
        {
            this.Nombre = nombre;
            this.Grupo = grupo;
            this.Telefono = telefono;
            this.Almacenamiento = true; //por defecto va en la SIM
        }

        //Metodos
        public static string PedirNombre(List<Contacto> ContactosTelefono)
        {
            bool nombreEncontrado = false;
            string nombre = "";
            Console.WriteLine("Dime el nombre del contacto");
            nombre = Console.ReadLine();
            while (String.IsNullOrEmpty(nombre))
            {
                Console.WriteLine("El nombre no puede ser nulo o vacío.");
                nombre = Console.ReadLine();
            }
            foreach (Contacto contacto in ContactosTelefono)
            {
                if (contacto.GetNombre() == nombre)
                {
                    nombreEncontrado = true;
                    bool lugar = contacto.GetAlmacenamiento();
                    string almacenamiento;
                    if (lugar)
                        almacenamiento = "SIM";
                    else
                        almacenamiento = "Memoria";
                    Console.WriteLine("El contacto ya está en la lista, está en {0}", almacenamiento);
                }
            }
            if (nombreEncontrado)
                nombre = "";
            return nombre;
 
        }

        public static string PedirGrupo()
        {
            string grupo = "";
            Console.WriteLine("Dime el nombre del grupo");
            grupo = Console.ReadLine();
            while (String.IsNullOrEmpty(grupo))
            {
                Console.WriteLine("El nombre del grupo no puede ser nulo o vacío.");
                grupo = Console.ReadLine();
            }
            return grupo;
        }

        public static int PedirNumero()
        {
            string numero;
            int telefono = 0;
            bool numeroValido;
            Console.WriteLine("Introduce el numero de telefono");
            numero = Console.ReadLine();

            if (numero[0] == '9' || (numero[0] == '8' || (numero[0] == 6)))
            {
                if (numero.Length == 9)
                {
                    Convert.ToInt32(numero);
                    if (Int32.TryParse(numero, out telefono))
                    {
                        numeroValido = true;
                    }
                    else
                        numeroValido = false;
                }
                else
                    numeroValido = false;
            }
            else
                numeroValido = false;
            if (!numeroValido)
                telefono = 0;

            return telefono;
        }

        //Metodo to string
        public override string ToString()
        {
            return $"Nombre: {Nombre}, Grupo: {Grupo}, Telefono: {Telefono}";
        }

        //Getters y Setters
        public void SetNombre(string nombre) { this.Nombre = nombre; }
        public string GetNombre() { return this.Nombre; }
        public void SetGrupo(string grupo) { this.Grupo = grupo; }
        public string GetGrupo() { return this.Grupo; }
        public void SetTelefono(int telefono) { this.Telefono = telefono; }
        public int GetTelefono() { return this.Telefono; }
        public void SetAlmacenamiento(bool almacenamiento) { this.Almacenamiento = almacenamiento; }
        public bool GetAlmacenamiento() { return this.Almacenamiento; } 
    }
}
