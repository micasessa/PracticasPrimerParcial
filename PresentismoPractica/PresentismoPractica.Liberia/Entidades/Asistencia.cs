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

        public Asistencia (string fechaRef, DateTime fechaHoraReal, bool estaPresente, Preceptor p, Alumno a)
        {
            _fechaReferencia = fechaRef;
            _fechaHoraReal = fechaHoraReal;
            _estaPresente = estaPresente;
            _preceptor = p;
            _alumno = a;
        }
        public Asistencia(string fechaRef, DateTime fechaHoraReal, Preceptor p, Alumno a)
        {
            _fechaReferencia = fechaRef;
            _fechaHoraReal = fechaHoraReal;
            _preceptor = p;
            _alumno = a;
        }

        public Asistencia(string fechaRef, DateTime fechaHoraReal)
        {
            _fechaReferencia = fechaRef;
            _fechaHoraReal = fechaHoraReal; 
        }

        //Des propiedades(getter)
        public string FechaReferencia { get => _fechaReferencia; }
        public DateTime FechaHoraReal { get => _fechaHoraReal; }
        public Preceptor Preceptor { get => _preceptor; }
        public Alumno Alumno { get => _alumno; }
        public bool EstaPresente { get => _estaPresente; set { _estaPresente = value; } }

        public string ToString()
        { //"FECHAREFERENCIA {ALUMNO FORMATEADO} está presente {SI o NO} por { PRECEPTOR FORMATEADO} registrado el { FECHAHORAREAL}"
            return _fechaReferencia + "{ " + _alumno + " } - Asistió:  " + _estaPresente + " por " + _preceptor + " - Registrado el " + _fechaHoraReal;
        }

    }
}
