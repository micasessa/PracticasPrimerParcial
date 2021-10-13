using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentismoPractica.Liberia.Utilidades
{
    public class AsistenciaInconsistenteException : Exception
    {
        public AsistenciaInconsistenteException() : base("La lista de asistencia ingresada no contiende la misma cantidad a la lista de alumnos regulares registrados")
        {

        }
    }
}
