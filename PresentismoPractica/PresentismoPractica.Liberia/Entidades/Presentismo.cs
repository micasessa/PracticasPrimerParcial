using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PresentismoPractica.Liberia.Utilidades;

namespace PresentismoPractica.Liberia.Entidades
{
    public class Presentismo
    {
        private List<Preceptor> _preceptores;
        private List<Alumno> _alumnos;
        private List<Asistencia> _asistencias;
        private List<string> _fechas;
        
        //Des propiedades
        public List<Preceptor> Preceptores { get => _preceptores; }
        public List<Alumno> Alumnos { get => _alumnos; }
        public List<Asistencia> Asistencias { get => _asistencias; }
        public List<string> Fechas { get => _fechas; }


        //Metodos enunciado (Vacios)
        private bool AsistenciaRegistrada (string fecha)
        { 
        }

        private int GetCantidadAlumnosRegulares()
        { }

        public Preceptor GetPreceptorActivo()
        { }

        public List<Alumno> GetListaAlumno(string a)
        { }

        public void AgregarAsistencia (List<Asistencia>, string a)
        { }
        public List<Asistencia> GetAsistenciasPorFecha (string a)
        { }

    }
}
