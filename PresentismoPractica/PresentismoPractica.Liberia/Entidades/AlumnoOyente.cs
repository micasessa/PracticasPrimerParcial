using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PresentismoPractica.Liberia.Utilidades;

namespace PresentismoPractica.Liberia.Entidades
{
    public class AlumnoOyente : Alumno 
    {
        public AlumnoOyente(int registro, string nombre, string apellido): base(registro, nombre, apellido)
        {

        }
        public AlumnoOyente (string nombre) : base(nombre)
        {
        }
    }
}
