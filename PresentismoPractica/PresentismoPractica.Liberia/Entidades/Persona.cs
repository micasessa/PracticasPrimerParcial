using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PresentismoPractica.Liberia.Utilidades;

namespace PresentismoPractica.Liberia.Entidades
{
    public abstract class Persona
    {
        protected string _nombre;
        protected string _apellido;

        //Desarrollo constructor
        public Persona() { }
        public Persona(string nombre, string apellido)
        {
            _nombre = nombre;
            _apellido = apellido;
        }
        
        //Falta desarrollo
        public string ToString()
        {
            return "Nombre: " + _nombre + " - Apellido: " + _apellido;
        }

        internal abstract string Display()
        { }
    }
}
