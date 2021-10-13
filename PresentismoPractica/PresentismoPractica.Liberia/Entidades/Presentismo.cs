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

        public List<Asistencia> Asistencias { get => _asistencias; }
        public List<string> Fechas { get => _fechas; }

        //Datos inicializacion
        public Presentismo()
        {
            _alumnos = new List<Alumno>();
            _asistencias = new List<Asistencia>();
            _preceptores = new List<Preceptor>();
            _fechas = new List<string>();
            _alumnos.Add(new AlumnoRegular(123, "Carlos", "Juarez", "cjua@gmail.com"));
            _alumnos.Add(new AlumnoRegular(124, "Carla", "Jaime", "cjai@gmail.com"));
            _alumnos.Add(new AlumnoOyente(320, "Ramona", "Vals"));
            _alumnos.Add(new AlumnoOyente(321, "Alejandro", "Medina"));
            _preceptores.Add(new Preceptor(5, "Jorgelina", "Ramos"));
        }

        //Metodos enunciado (Vacios)
        private bool AsistenciaRegistrada(string fecha)
        {
            if (_fechas.Contains(fecha) == true)
            {
                return true; //ya se registro una asistencia con la fecha ingresada por el usuario
            } else
            {
                return false; //todavia no se registro una asistencia
            }
        }

        private int GetCantidadAlumnosRegulares()
        {
            int cantAlumnosReg = 0;
            foreach (Alumno aReg in _alumnos)
            {
                if (aReg is AlumnoRegular)
                {
                    cantAlumnosReg = cantAlumnosReg + 1;
                }
            }
            return cantAlumnosReg;
        }

        public Preceptor GetPreceptorActivo()
        {
            if (_preceptores.Any() == true)
            {
                return _preceptores.Last();
            } else
            {
                throw new AsistenciaInconsistenteException();
            }
        }

        public List<Alumno> GetListaAlumno(string fecha)
        {
            if (_alumnos.Count() <= 0)
            {
                throw new SinAlumnosRegistradosException();
            } else
            {
                return _alumnos;
            }
        }

        public void AgregarAsistencia(List<Asistencia> listaAsis, string fechaAsis)
        {   //b) En caso que la lista de asistencia ingresada no tenga una cantidad igual a la lista de alumnos regulares registrados, se debe arrojar una AsistenciaInconsistenteException.
            if (listaAsis.Count() == GetCantidadAlumnosRegulares())
            {   //c) Solo se puede agregar a la lista(_asistencias) una vez por fecha y cada vez que se ingresen asistencias a la lista(_asistencias)
                //se debe ingresar un string a la lista de fechas(_fechas). Tip: firma de AgregarAsistencia(List < Asistencia > asistencias, string fecha)
                //d) En caso que la fecha ya exista en la lista(_fechas) se deberá arrojar una AsistenciaExistenteEseDiaException.
                if (AsistenciaRegistrada(fechaAsis))
                {
                    throw new AsistenciaExistenteEseDiaException(); //porque no puede pasar que se registre una asistencia en una fecha ya hecha.
                }
                else
                {
                    Asistencia asistencia = new Asistencia(fechaAsis, DateTime.Now);
                    _asistencias.Add(asistencia);
                    _fechas.Add(fechaAsis);
                }
            } else
            {
                throw new AsistenciaInconsistenteException();
            }
        }
        public List<Asistencia> GetAsistenciasPorFecha(string fechaIngresada)
        {
            //Tengo que instanciar una nueva lista para guardar asistencias por fecha. 
            List<Asistencia> asistenciasPorFecha = new List<Asistencia>();

            //busco en metodo AsistReg que la fecha ingresada por el usuario esté en mi lista de fechas
            if (AsistenciaRegistrada(fechaIngresada) == true)
            {   //TRUE: busco por cada asistencia en _asistencia si la fecha en a1 coincide con la fecha 
                //ingresada por el usuario para ver una lista det
                foreach (Asistencia a1 in _asistencias)
                {
                    if (a1.FechaReferencia == fechaIngresada)
                    {   //si coinciden: agrego la asistencia a mi nueva lista que cree en este metodo
                        asistenciasPorFecha.Add(a1);
                    }
                }
                if (asistenciasPorFecha.Count > 0)
                {
                    return asistenciasPorFecha; //para el caso que exista una lista de asistencia 
                } else
                {
                    throw new SinAlumnosRegistradosException();
                }


            } else
            {
                Console.WriteLine("No existe una asistencia por la fecha ingresada");
            }
        }
    
    }
}
