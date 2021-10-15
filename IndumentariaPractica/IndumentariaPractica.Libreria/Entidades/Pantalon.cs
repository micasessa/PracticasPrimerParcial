using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndumentariaPractica.Libreria.Utilidades;

namespace IndumentariaPractica.Libreria.Entidades
{
    public  class Pantalon:Indumentaria
    {
        public string Material;
        public bool TieneBolsillos;

        //no declaro las propiedades porque las variables son publicas
        public Pantalon () { }
        public Pantalon (int codigo, int stock, string talle, double precio, string material, bool tieneBolsillos) : base(codigo, stock, talle, precio)
        {
            Material = material;
            TieneBolsillos = tieneBolsillos;
        }

        public string Bolsillo
        {
            get
            {
                if (TieneBolsillos == true)
                {
                    return "SI";
                }
                else
                {
                    return "NO";
                }
            }
        }

        public override string GetDetalle()
        {
            return "Cod: " + Codigo + " - Tipo: " + Tipo + " - Stock: " + Stock + " - Talle: " + Talle + " - Precio: " + Precio + " - Bolsillo: " + Bolsillo
                + " - Material: " + Material;
        }
    }
}
