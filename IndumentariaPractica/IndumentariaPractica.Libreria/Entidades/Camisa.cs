using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndumentariaPractica.Libreria.Entidades
{
    public class Camisa : Indumentaria
    {
        public bool TieneEstampado;
        public string TipoManga;

        //no declaro las propiedades porque las variables son publicas

        public string GetDetalle()
        { }
    }
}
