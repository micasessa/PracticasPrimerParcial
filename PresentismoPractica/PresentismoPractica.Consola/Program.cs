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
            DesplegarOpcionesMenu();
            string opcionMenu = Validador.pedirString ("Ingrese una opcion del menu"); // pedir el valor
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
        }
        static void DesplegarOpcionesMenu()
        {
            Console.WriteLine("1) Tomar Asistencia");
            Console.WriteLine("2) Mostrar Asistencia");
            Console.WriteLine("X: Terminar");
        }
        static void TomarAsistencia(Preceptor p)
        {
            // Ingreso fecha
            // Listar los alumnos
            // para cada alumno solo preguntar si está presente
            // agrego la lista de asistencia
            // Error: mostrar el error y que luego muestre el menu nuevamente
        }
        static void MostrarAsistencia()
        {
            // ingreso fecha
            // muestro el toString de cada asistencia
        }
    }
}
