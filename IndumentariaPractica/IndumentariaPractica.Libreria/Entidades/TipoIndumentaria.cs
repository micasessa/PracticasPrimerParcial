using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndumentariaPractica.Libreria.Utilidades;

namespace IndumentariaPractica.Libreria.Entidades
{
    public abstract class TipoIndumentaria
    {
        public string Origen;
        public double PorcentajeAlgodon;

        //no declaro las propiedades porque las variables son publicas
        //Des constructores
        public TipoIndumentaria() { }
        public TipoIndumentaria(string origen, double porcentajeAlgodon)
        {
            Origen = origen;
            PorcentajeAlgodon = porcentajeAlgodon;
        }
    }
}
