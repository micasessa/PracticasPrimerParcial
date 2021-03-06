using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndumentariaPractica.Libreria.Utilidades;

namespace IndumentariaPractica.Libreria.Entidades
{
    public class TiendaRopa
    {
        private List<Indumentaria> _Inventario;
        private List<Venta> _Ventas;
        private int _ultimoCodigo; //* Cada codigo dentro de la aplicacion lo maneja lo asigna TiendaRopa (mantiene un contador interno)

        //Propiedades getter:
        public List<Indumentaria> Inventario { get => _Inventario; }
        public List<Venta> Ventas { get => _Ventas; }

        //Constructores
        public TiendaRopa() { }
        public TiendaRopa(int ultimoCodigo) 
        {
            _ultimoCodigo = ultimoCodigo;
            _Inventario = new List<Indumentaria>();
            _Ventas = new List<Venta>();
        }


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
        {
            if (_Inventario.Any() == true)
            {
                return _Inventario;
            }
            else
            {
                throw new Exception("No hay inventario");
            }           
            
        }

        public List<Orden> ListarOrden()
        { }

        public void DevolverOrden(Orden)
        { }
    }
}
