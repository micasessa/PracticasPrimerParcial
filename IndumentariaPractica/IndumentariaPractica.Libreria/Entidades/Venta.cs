using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndumentariaPractica.Libreria.Utilidades;

namespace IndumentariaPractica.Libreria.Entidades
{
    public class Venta
    {
        public List<VentaItem> Items;
        public Cliente Cliente;
        public int Estado;
        public int Codigo;

        //no declaro las propiedades porque las variables son publicas
        //Desarrollo constructores:
        public Venta() { }
        public Venta( int estado, int codigo)
        {
            estado = Estado;
            codigo = Codigo;
            Cliente = new Cliente();
            Items = new List<VentaItem>();
        }


        //Metodo vacio
        public double GetTotalPedido()
        { }
    }
}
