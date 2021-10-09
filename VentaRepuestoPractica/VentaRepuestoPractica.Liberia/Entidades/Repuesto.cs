using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaRepuestoPractica.Libreria.Entidades
{
    public class Repuesto
    {
        private int _codigo;
        private string _nombre;
        private double _precio;
        private int _stock;
        private Categoria _categoria;

        //Desarrollo getter + set
        public int Codigo { get => _codigo; }
        public string Nombre { get => _nombre; }
        public double Precio { get { return _precio; } set { _precio = value; } }
        public int Stock { get { return _stock; } set { _stock = value; } }
        public Categoria Categoria { get => _categoria; }

        //Desarrollo constructor.  1 vacio y otro con vars
        public Repuesto () { }
        public Repuesto(int codigo, string nombre, double precio, int stock, Categoria cat)
        {
            _codigo = codigo;
            _nombre = nombre;
            _precio = precio;
            _stock = stock;
            _categoria = new Categoria();
        }
        public Repuesto (int codigo, string nombre, double precio, int stock, int codigoCat, string nombreCat)
        {
            _codigo = codigo;
            _nombre = nombre;
            _precio = precio;
            _stock = stock;
            _categoria = new Categoria(codigo, nombre);
        }

        //Desarrollo metodo UML
        public string ToString()
        {
            //MUESTRO LOS DATOS DE LOS REPUESTOS!
            return "Codigo: " + Codigo + "\n Nombre: " + Nombre +
                "\n Precio: " + Precio + "\n Stock: " + Stock + "\n Categoria: " + Categoria ;
        }
    }
}
