using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndumentariaPractica.Libreria.Entidades
{
    public abstract class Indumentaria
    {
        public TipoIndumentaria Tipo;
        public int Codigo;
        public int Stock;
        public string Talle;
        public double Precio;

        //no declaro las propiedades porque las variables son publicas

        //Metodo
        public string ToString()
        { }

        public bool Equals()
        { }

        public abstract string GetDetalle()
        { }
    }
}
