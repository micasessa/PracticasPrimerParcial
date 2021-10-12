using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentismoPractica.Liberia.Utilidades
{
    public class AsistenciaExistenteEseDiaException :Exception
    {
        public AsistenciaExistenteEseDiaException(): base ("Ya se tomó asistencia este dia.")
        {

        }
    }
}
