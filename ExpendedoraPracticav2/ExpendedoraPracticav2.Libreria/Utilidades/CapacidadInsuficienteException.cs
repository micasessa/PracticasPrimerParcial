using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpendedoraPracticav2.Libreria.Utilidades
{
    public class CapacidadInsuficienteException :Exception
    {
        public CapacidadInsuficienteException(string message) : base("Ya no hay mas capacidad para agregar bebidas a la maquina")
        {
        }

    }
}
