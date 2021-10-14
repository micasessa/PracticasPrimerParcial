using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndumentariaPractica.Libreria.Entidades
{
    public class Venta
    {
        public List<VentaItem> Items;
        public Cliente Cliente;
        public int Estado;
        public int Codigo;


        //no declaro las propiedades porque las variables son publicas

        //Metodo vacio
        public double GetTotalPedido()
        { }
    }
}
