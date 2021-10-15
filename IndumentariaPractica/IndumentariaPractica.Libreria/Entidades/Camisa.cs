using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndumentariaPractica.Libreria.Utilidades;

namespace IndumentariaPractica.Libreria.Entidades
{
    public class Camisa : Indumentaria
    {
        public bool TieneEstampado;
        public string TipoManga;

        //no declaro las propiedades porque las variables son publicas
        //Declaro constructores
        public Camisa() { }
        public Camisa (int codigo, int stock, string talle, double precio, bool tieneEstampado, string tipoManga): base(codigo, stock, talle, precio)
        {
            TieneEstampado = tieneEstampado;
            TipoManga = tipoManga;
        }

        public override string GetDetalle()
        { }
    }
}
