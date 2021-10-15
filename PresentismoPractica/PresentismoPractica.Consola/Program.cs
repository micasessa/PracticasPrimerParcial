using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PresentismoPractica.Liberia.Utilidades;
using Validaciones;
using PresentismoPractica.Liberia.Entidades;

namespace PresentismoPractica.Consola
{
    public class Program
    {
        private static Presentismo _presentismo;
        static Program()
        {
            _presentismo = new Presentismo();
        }
        static void Main(string[] args)
        {
            Preceptor preceptorActivo = _presentismo.GetPreceptorActivo();
            string opcionMenu;
            do
            {
                DesplegarOpcionesMenu();
                opcionMenu = Validador.pedirString("Ingrese una opcion del menu"); // pedir el valor
                switch (opcionMenu)
                {
                    case "1":
                        TomarAsistencia(preceptorActivo);
                        break;
                    case "2":
                        MostrarAsistencia();
                        break;
                    case "X":
                        // SALIR
                        break;
                    default:
                        break;
                }
            } while (opcionMenu != "X");
                 
        }
        static void DesplegarOpcionesMenu()
        {
            Console.WriteLine("1) Tomar Asistencia");
            Console.WriteLine("2) Mostrar Asistencia");
            Console.WriteLine("X: Terminar");
        }

        //2) Se deberá poder tomar asistencia de un día en particular (ingresado por usuario) a todos los alumnos regulares registrados. (Alta Asistencia)
        static void TomarAsistencia(Preceptor p)
        {
            try
            {
                // Ingreso fecha
                string fechaAsistencia = Validador.pedirString("Ingrese la fecha:");
                //creo una nueva lista de asistencia
                List<Asistencia> listaasistencia1 = new List<Asistencia>();
                // Listar todos los alumnos (regulares y oyentes)
                foreach (Alumno al in _presentismo.GetListaAlumno(fechaAsistencia))
                { 
                    //Si el alumno no es regular, mostrar por pantalla “El alumno {FORMATO} es oyente” y no pedir asistencia ni agregar a la lista de asistencia.
                    if (al is AlumnoRegular)
                    {   //Agrego una asistencia con los datos que ya tengo (fecha pedida al usuario, preceptor, todos los alumnos regulares)
                        Asistencia asistencia1;
                        //para cada alumno solo preguntar si está presente
                        string alumnoPresente = Validador.pedirString (al.ToString() + "está presente? SI / NO ?").ToUpper();
                        
                        if (alumnoPresente == "SI")
                        {   
                            asistencia1 = new Asistencia(fechaAsistencia, DateTime.Now, true, p, al);                            
                        }
                        else
                        {
                            asistencia1 = new Asistencia(fechaAsistencia, DateTime.Now, false, p, al);
                            Console.WriteLine("El alumno no está presente.");
                        }
                        // agrego la lista de asistencia
                        listaasistencia1.Add(asistencia1);
                    }
                    else
                    {
                        Console.WriteLine("El alumno " + al.ToString() + " es oyente." ); //Porque el alumno no es regular. no se le pide asistencia y no se agrega a la lista
                    }
                    
                }
                _presentismo.AgregarAsistencia(listaasistencia1, fechaAsistencia);
                Console.WriteLine("Asistencia agregada");
                Console.ReadLine();
            }
            catch (AsistenciaExistenteEseDiaException ex)
            {
                Console.WriteLine(ex.Message);
            } 
            catch (SinAlumnosRegistradosException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se puede tomar asistencia. Intentelo de nuevo");
            }
        }

        //3) Se deberá poder listar las asistencias de una fecha ingresada por el usuario con su {FORMATO }. (Listar Asistencia)
        static void MostrarAsistencia()
        {
            try
            {
                // ingreso fecha
                string fechaAsistencia = Validador.pedirString("Ingrese la fecha:");
                // muestro el toString de cada asistencia
                List<Asistencia> asistPorFecha = _presentismo.GetAsistenciasPorFecha(fechaAsistencia);
                Console.WriteLine("La asistencia para la fecha " + fechaAsistencia + " es:");
                foreach (Asistencia a2 in asistPorFecha)
                {
                    if (a2.FechaReferencia == fechaAsistencia)
                    {
                        Console.WriteLine(a2.ToString()); //Muestro las asistencias de la fecha ingresada
                    }
                    else
                    {
                        //En caso que no haya asistencias mostrar “No hay registros para la fecha {FECHAINGRESADA}”.
                        Console.WriteLine("No hay registros para la fecha " + fechaAsistencia);
                    }
                }
            }
            catch (SinAlumnosRegistradosException ex)
            {
                Console.WriteLine("No hay alumnos registrados");
            }
            
            catch (Exception ex)
            {
                Console.WriteLine("No existe una asistencia por la fecha ingresada");
            }

        }
    }
}
