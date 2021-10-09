using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaRepuestoPractica.Libreria.Entidades
{
    public class VentaRepuestos
    {
        private List<Repuesto> _listaProductos;
        private string _nombreComercio;
        private string _direccion;

        //Desarrollo GETTER
        public string NombreComercio { get => _nombreComercio; }
        public string Direccion { get => _direccion; }

        //Desarrollo Constructor (?)

        //Metodos del UML. Falta Desarrollo. ver tema variables puestas entreparentesis(al voleo)
        public void AgregarRepuesto(Repuesto)
        { }

        public void QuitarRepuesto (int Codigo)
        { }

        public void ModificarPrecio(int Codigo, double Precio)
        { }

        public void AgregarStock (int Codigo, int Stock)
        { }

        public void QuitarStock (int Codigo, int Stock)
        { }

        public List<Repuesto> TraerPorCategoria (int Codigo)
        {
            List<Repuesto> repuestos = new List<Repuesto>();
            foreach (Repuesto item in _listaProductos)
            {
                if (item.Categoria.Codigo == Codigo)
                {
                    repuestos.Add(item);
                }
            }
            return repuestos;

        }

        //Desarrollarlo para obtener el cod max y que el usuario pueda agregar un nuevo repuesto.
        public int ObtenerCodigoMaximo()
        {
            throw new NotImplementedException();
        }
    }
}
