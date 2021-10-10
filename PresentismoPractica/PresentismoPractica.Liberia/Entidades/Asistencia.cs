using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PresentismoPractica.Liberia.Utilidades;

namespace PresentismoPractica.Liberia.Entidades
{
    public class Asistencia 
    {
        private string _fechaReferencia;
        private DateTime _fechaHoraReal;
        private Preceptor _preceptor;
        private Alumno _alumno;
        private bool _estaPresente;        

        //Des constructores
        public Asistencia() { }

        public Asistencia (string fechaRef, DateTime fechaHoraReal, bool estaPresente)
        {
            _fechaReferencia = fechaRef;
            _fechaHoraReal = fechaHoraReal;
            _estaPresente = estaPresente;
            _preceptor = new Preceptor();
            //_alumno = new Alumno();

        }

        //Des propiedades(getter)
        public string FechaReferencia { get => _fechaReferencia; }
        public DateTime FechaHoraReal { get => _fechaHoraReal; }
        public Preceptor Preceptor { get => _preceptor; }
        public Alumno Alumno { get => _alumno; }
        public bool EstaPresente { get => _estaPresente; }

        public string ToString()
        {

        }

    }
}
