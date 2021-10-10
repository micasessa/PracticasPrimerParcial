using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpendedoraPractica.Libreria.Utilidades;

namespace ExpendedoraPractica.Libreria.Entidades
{
    public class Lata
    {
        private string _codigo;
        private string _nombre;
        private string _sabor;
        private double _precio;
        private double _volumen;
        private int _cantidad;

        //des constructores
        public Lata() { }
        public Lata(string codigo, string nombre, string sabor, double precio, double volumen, int cantidad)
        {
            _codigo = codigo;
            _nombre = nombre;
            _sabor = sabor;
            _precio = precio;
            _volumen = volumen;
            _cantidad = cantidad;
        }

        //des getter y setter
        public string Codigo { get => _codigo; }
        public string Nombre { get => _nombre; }
        public string Sabor { get => _sabor; }
        public double Precio { get => _precio; set { _precio = value; } }
        public double Volumen { get => _volumen; set { _volumen = value; } }
        public int Cantidad { get => _cantidad; set { _cantidad = value; } }

        //des metodos vacios
        private double GetPrecioPorLitro()
        { }

        public string ToString()
        { }
    }
}
