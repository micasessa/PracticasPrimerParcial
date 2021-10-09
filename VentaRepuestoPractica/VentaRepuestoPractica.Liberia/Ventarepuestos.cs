using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaRepuestoPractica.Liberia
{
    public class Ventarepuestos
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
            Console.WriteLine("Falta desarrollo");
        }
    }
}
