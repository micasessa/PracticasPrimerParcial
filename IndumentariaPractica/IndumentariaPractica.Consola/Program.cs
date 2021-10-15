using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndumentariaPractica.Libreria.Entidades;
using IndumentariaPractica.Libreria.Utilidades;
using Validaciones;

namespace IndumentariaPractica.Consola
{
    class Program
    {
        private static TiendaRopa _tiendaRopa;
        static Program()
        {
            _tiendaRopa = new TiendaRopa();
        }
        static void Main(string[] args)
        {            
            string opcionMenu;
            do
            {
                DesplegarOpcionesMenu();
                opcionMenu = Validador.pedirString("Ingrese una opcion del menu"); // pedir el valor
                switch (opcionMenu)
                {
                    case "1":
                        ListarIndumentaria();
                        break;
                    case "2":
                        AgregarIndumentaria();
                        break;
                    case "3":
                        ModificarIndumentaria();
                        break;
                    case "4":
                        EliminarIndumentaria();
                        break;
                    case "5":
                        ListarOrdenes();
                        break;
                    case "6":
                        IngresarOrdenes();
                        break;
                    case "7":
                        DevolverOrdenes();
                        break;
                    case "8":
                        // SALIR
                        break;
                    default:
                        break;
                }
            } while (opcionMenu != "8");

        }

        private static void ListarIndumentaria()
        {
            throw new NotImplementedException();
        }

        private static void AgregarIndumentaria()
        {
            throw new NotImplementedException();
        }

        private static void ModificarIndumentaria()
        {
            throw new NotImplementedException();
        }

        private static void EliminarIndumentaria()
        {
            throw new NotImplementedException();
        }

        private static void ListarOrdenes()
        {
            throw new NotImplementedException();
        }

        private static void IngresarOrdenes()
        {
            throw new NotImplementedException();
        }

        private static void DevolverOrdenes()
        {
            throw new NotImplementedException();
        }

        static void DesplegarOpcionesMenu()
        {
            Console.WriteLine("Bienvenido");
            Console.WriteLine("1 - Listar Indumentarias");
            Console.WriteLine("2 - Agregar Indumentaria");
            Console.WriteLine("3 - Modificar Indumentaria");
            Console.WriteLine("4 - Eliminar Indumentaria");
            Console.WriteLine("5 - Listar ordenes");
            Console.WriteLine("6 - Ingresar ordenes");
            Console.WriteLine("7 - Devolver Orden");
            Console.WriteLine("8 - Salir"); 
        }

     


    }
}
