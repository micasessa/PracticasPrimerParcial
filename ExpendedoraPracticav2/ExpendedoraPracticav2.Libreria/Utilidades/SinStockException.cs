using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpendedoraPracticav2.Libreria.Utilidades
{
    public class SinStockException : Exception 
    {
        public SinStockException(int cantidad) : base("No hay suficiente stock")
        {
        }
    }
}
