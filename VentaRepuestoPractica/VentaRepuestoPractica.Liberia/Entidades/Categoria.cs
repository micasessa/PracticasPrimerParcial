using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaRepuestoPractica.Libreria.Entidades
{
    public class Categoria
    {
        private int _codigo;
        private string _nombre;

        //Desarrollo getter
        public int Codigo { get => _codigo; }
        public string Nombre { get => _nombre; }

        //Desarrollo constructor(?)
        public Categoria (int codigo, string nombre)
        { 
            _codigo = codigo;
            _nombre = nombre;
        }
        public Categoria()
        {
            
        }

    }
}
