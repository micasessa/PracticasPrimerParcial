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
        public double Precio { get => _precio; }
        public int Stock { get => _stock; }
        public Categoria Categoria { get => _categoria; }

        //Desarrollo constructor 
        public Repuesto (int codigo, string nombre, double precio, int stock, Categoria cat)
        {
            _codigo = codigo;
            _nombre = nombre;
            _precio = precio;
            _stock = stock;
            _categoria = cat;
        }

        //Desarrollo metodo UML
        public string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
