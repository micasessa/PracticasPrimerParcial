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

        //Listar Indumentarias (GetDetalle())
        private static void ListarIndumentaria()
        {
            try
            {
                foreach (Indumentaria i in _tiendaRopa.Listar())
                {
                    Console.WriteLine(i.GetDetalle());
                }
                Console.ReadLine();
            } catch (Exception ex) 
            {
                Console.WriteLine("No hay inventario");
            }
        }

        //- Agregar Indumentaria (por defecto cada indumentaria ingresa con 3 de stock)
        private static void AgregarIndumentaria()
        {
            //inicializo las variables:
            string tipo;
            int codigo;
            string talle;
            double precio;

            //pido al usuario que agregue: (el codigo va a ser asignado automaticamente x ultimoCodigo)
            tipo = Validador.pedirString("Ingrese el tipo de indumentaria.CASUAL/FORMAL/DEPORTIV ").ToUpper();
            talle = Validador.pedirString("Ingrese el talle");
            precio = Validador.pedirDouble("Ingrese el precio");

            //Agrego variables a Indumentaria
            Indumentaria ind1 = new Indumentaria( talle, precio);

        
        }
    }

        private static void ModificarIndumentaria()
        {
            throw new NotImplementedException();
        }

        private static void EliminarIndumentaria()
        {
            throw new NotImplementedException();
        }

        //- Listar ordenes (con el formato "codigo) Apellido, Nombre Cliente, cantidad prendas, $ total pedido"
        private static void ListarOrdenes()
        {
            throw new NotImplementedException();
        }

        //- Ingresar Orden (debe restar stock de la prenda seleccionada)
        //- Cuando inicia la orden el estado es inciada
        //Cuando el cliente deja de ingresar items el estado es prosada

        private static void IngresarOrdenes()
        {
            throw new NotImplementedException();
        }

        //- Devolver Orden (debe volver al stock de la prenda)
        //- Cuando el cliente Devuelve el estado pasa a devuelto
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
