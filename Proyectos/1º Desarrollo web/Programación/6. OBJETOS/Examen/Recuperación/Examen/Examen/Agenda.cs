using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Examen
{
    class Agenda
    {
        /// <summary> Lista de contactos </summary>
        private List<Contacto> ContactosTelefono { get; set; }

        //constructores
        public Agenda(List<Contacto> contactosTelefono)
        {
            this.ContactosTelefono = contactosTelefono;
        }
        public Agenda()
        {
            this.ContactosTelefono = new List<Contacto>();
        }

        //Metodos
        public bool ValidarContacto(string nombre)
        {
            bool nombreEncontrado = false;
            foreach (Contacto contacto in ContactosTelefono)
            {
                if (contacto.GetNombre() == nombre)
                {
                    nombreEncontrado = true;
                }
            }
            return nombreEncontrado;
        }
        public bool ValidarMemoria(string nombre)
        {
            bool memoria = false;
            memoria = this.ContactosTelefono.Find(contacto => contacto.GetNombre().Equals(nombre)).GetAlmacenamiento();
            return memoria;
        }
        public bool MoverAMemoria(string nombre)
        {
            bool almacenamiento;
            bool resultado = false;
            foreach (Contacto contacto in ContactosTelefono)
            {
                if (contacto.GetNombre() == nombre)
                {
                    almacenamiento = contacto.GetAlmacenamiento();
                    if (almacenamiento)
                    {
                        contacto.SetAlmacenamiento(false);
                        resultado = true;
                    }
                }
            }
            return resultado;
        }
        public bool MoverASim(string nombre)
        {
            bool almacenamiento;
            bool resultado = false;
            foreach (Contacto contacto in ContactosTelefono)
            {
                if (contacto.GetNombre() == nombre)
                {
                    almacenamiento = contacto.GetAlmacenamiento();
                    if (!almacenamiento)
                    {
                        contacto.SetAlmacenamiento(true);
                        resultado = true;
                    }
                }
            }
            return resultado;
        }
        public bool ModificarGrupo(string nombre, string grupo)
        {
            bool almacenamiento;
            bool resultado = false;
            foreach (Contacto contacto in ContactosTelefono)
            {
                if (contacto.GetNombre() == nombre)
                {
                    almacenamiento = contacto.GetAlmacenamiento();
                    if (!almacenamiento)
                    {
                        contacto.SetGrupo(grupo);
                        resultado = true;
                    }
                }
            }
            return resultado;
        }
        public bool ModificarTelefono(string nombre, int telefono)
        {
            bool almacenamiento;
            bool resultado = false;
            foreach (Contacto contacto in ContactosTelefono)
            {
                if (contacto.GetNombre() == nombre)
                {
                    almacenamiento = contacto.GetAlmacenamiento();
                    if (!almacenamiento)
                    {
                        contacto.SetTelefono(telefono);
                        resultado = true;
                    }
                }
            }
            return resultado;
        }
        public static void ContactosSIM(List<Contacto> ContactosTelefono)
        {
            foreach (Contacto contacto in ContactosTelefono)
            {
                if (contacto.GetAlmacenamiento() == true)
                    Console.WriteLine(contacto);
            }
        }
        public static void ContactosMemoria(List<Contacto> ContactosTelefono)
        {
            foreach (Contacto contacto in ContactosTelefono)
            {
                if (contacto.GetAlmacenamiento() == false)
                    Console.WriteLine(contacto);
            }
        }

        //Getters y Setters
        public void SetMemoria(List<Contacto> contactosTelefono) { this.ContactosTelefono = contactosTelefono; }
        public List<Contacto> GetMemoria() { return ContactosTelefono; }
    }
}
