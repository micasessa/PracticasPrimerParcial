using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaRepuestoPractica.Libreria.Entidades;

namespace VentaRepuestoPractica.Liberia.Utility
{
    public static class RepuestoHelper
    {
        private static List<Repuesto> _listaRepuesto;
        static RepuestoHelper()
        {
            _listaRepuesto = new List<Repuesto>();
            Repuesto rep1 = new Repuesto(1, "Rueda delantera", 20000, 5);


        }
    }
}
