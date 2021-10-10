using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PresentismoPractica.Liberia.Utilidades;

namespace PresentismoPractica.Liberia.Entidades
{
    public class AlumnoRegular : Alumno
    {
        private string _email;

        //Des constructor
        public AlumnoRegular(int registro, string nombre, string apellido, string email) : base(registro, nombre, apellido)
        {
            _email = email;
        }

        //Des getter
        public string Email { get => _email; }
    }
}
