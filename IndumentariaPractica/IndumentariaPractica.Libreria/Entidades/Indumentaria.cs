using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndumentariaPractica.Libreria.Utilidades;

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
        public Indumentaria() { }
        
        public Indumentaria (int codigo, int stock = 3 , string talle, double precio)
        {
            Codigo = codigo;
            Stock = stock;
            Talle = talle;
            Precio = precio;
        }

        public Indumentaria (TipoIndumentaria tipo, string talle, double precio)
        {
            Talle = talle;
            Precio = precio;
            Tipo = tipo;
        }

        //Metodo
        public string ToString()
        {
            return GetDetalle();
        }

        public bool Equals()
        { }

        public abstract string GetDetalle();
        
    }
}
