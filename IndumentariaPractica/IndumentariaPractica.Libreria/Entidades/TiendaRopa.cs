using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndumentariaPractica.Libreria.Entidades
{
    public class TiendaRopa
    {
        private List<Indumentaria> _Inventario;
        private List<Ventas> _Ventas;
        private int _ultimoCodigo;


        //Metodos sin desarrollar:
        private int GetProximoCodigo()
        { }

        public void Agregar(Indumentaria)
        { }

        public void Modificar(Indumentaria)
        { }

        public void Quitar (Indumentaria)
        { }

        public void IngresarOrden (Venta)
        { }

        public List<Indumentaria> Listar()
        { }

        public List<Orden> ListarOrden()
        { }

        public void DevolverOrden(Orden)
        { }
    }
}
