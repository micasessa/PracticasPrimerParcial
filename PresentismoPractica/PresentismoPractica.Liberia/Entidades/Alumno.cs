using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PresentismoPractica.Liberia.Utilidades;

namespace PresentismoPractica.Liberia.Entidades
{
    public abstract class Alumno : Persona
    {
        private int _registro;

        //Desarrollo constructor
        public Alumno() { }
        public Alumno(string nombre) : base (nombre) { }
        public Alumno(int registro, string nombre, string apellido) : base(nombre, apellido)
        {
            _registro = registro;
        }
        public Alumno(int registro, string nombre) : base(nombre)
        {
            _registro = registro;
        }


        //Des getter
        public int Registro { get => _registro; }

        internal override string Display()
        { //“NOMBRE (REGISTRO)”
            return  _nombre + " (" + _registro + ")" ;
        }

    }
}
