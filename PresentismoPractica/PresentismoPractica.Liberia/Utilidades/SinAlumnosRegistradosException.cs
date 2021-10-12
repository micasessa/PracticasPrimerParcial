using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentismoPractica.Liberia.Utilidades
{
    public class SinAlumnosRegistradosException : Exception
    {
        public SinAlumnosRegistradosException() : base("El alumno es oyente, no está registrado")
        {

        }
    }
}
