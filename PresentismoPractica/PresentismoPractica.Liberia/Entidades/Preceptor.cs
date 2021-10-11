using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PresentismoPractica.Liberia.Utilidades;

namespace PresentismoPractica.Liberia.Entidades
{
    public class Preceptor : Persona
    {
        private int _legajo;
        
        //Desarrollo constructor
        public Preceptor() { }
        public Preceptor (int legajo, string nombre, string apellido) : base(nombre, apellido)
        {
            _legajo = legajo;
        }

        //Des getter
        public int Legajo { get => _legajo; }
        internal override string Display()
        { //“APELLIDO - LEGAJO”
            return "Apellido " + _apellido + " - Legajo " + _legajo;
        }
    }
}
