using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndumentariaPractica.Libreria.Utilidades;

namespace IndumentariaPractica.Libreria.Entidades
{
    public class VentaItem
    {
        public Indumentaria Prenda;
        public int Cantidad;

        //no declaro las propiedades porque las variables son publicas
        //Desarrollo constructores
        public VentaItem() { }
        public VentaItem(int cantidad, Indumentaria prenda) 
        {
            Cantidad = cantidad;
            Prenda = prenda;
        }


        public double GetTotal()
        { }

    }
}
