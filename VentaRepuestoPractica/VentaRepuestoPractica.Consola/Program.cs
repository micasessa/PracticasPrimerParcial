using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaRepuestoPractica.Libreria.Entidades;
using Validaciones;

namespace VentaRepuestoPractica.Consola
{
    class Program
    {
        static bool _consolaActiva;
        static VentaRepuestos _tiendaRepuestos;

        static Program()
        {
            _consolaActiva = true;
            _tiendaRepuestos = new VentaRepuestos();            
        }
        static void Main(string[] args)
        {
            string opcion;
            do
            {
                DesplegarOpcionesMenu();
                opcion = Validador.pedirString("Elija una opcion");
                switch (opcion)
                {
                    case "1":
                        NuevoRepuesto();
                        break;
                    case "2":
                        EliminarRepuesto();
                        break;
                    case "3":
                        ModificaPrecio();
                        break;
                    case "4":
                        AgregarStock();
                        break;
                    case "5":
                        QuitarStock();
                        break;
                    case "6":
                        ListarRepuesto();
                        break;
                    case "7":
                        _consolaActiva = false;
                        break;
                    default:
                        Console.WriteLine("Opcion invalida.");
                        break;
                }

            } while (_consolaActiva);
            
            
        }

        private static void NuevoRepuesto()
        {
            //Agrego un nuevo repuesto. Creo las variables (iguales a las de la clase repuesto)
            int codigo;
            string nombre;
            double precio;
            int stock;
            int codCategoria;

            //Pido al usuario que ingrese la informacion del nuevo repuesto
            //Para el codigo busco el codigoMaximo
            codigo = _tiendaRepuestos.ObtenerCodigoMaximo();
            nombre = Validador.pedirString("Ingrese el Nombre del repuesto");
            precio = Validador.pedirDouble("Ingrese el precio");
            stock = Validador.pedirInt("Ingrese el stock del repuesto");

            //Muestro las categorias para que el usuario elija. hago un foreach!!
            Console.WriteLine("Las categorias son:");
            foreach (Categoria c in CategoriaListas.)

            
        }

        

        private static void EliminarRepuesto()
        {
            throw new NotImplementedException();
        }

        private static void ModificaPrecio()
        {
            throw new NotImplementedException();
        }

        private static void QuitarStock()
        {
            //Quitar stock de un repuesto
        }

        private static void AgregarStock()
        {
            //Agregar stock de un repuesto
        }

        private static void ListarRepuesto()
        {
            //Listar repuestos por categorias
        }

        static void DesplegarOpcionesMenu()
        {
            Console.WriteLine("******* Menu *******");
            Console.WriteLine("1- Agregar respuesto");
            Console.WriteLine("2- Quitar repuesto");
            Console.WriteLine("3- Modificar precio");
            Console.WriteLine("4- Agregar stock");
            Console.WriteLine("5- Quitar stock");
            Console.WriteLine("6- Traer por repuestos por categoria");
            Console.WriteLine("7- Salir");
        }

        

    }
}
