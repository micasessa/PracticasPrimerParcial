using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaRepuestoPractica.Libreria.Entidades;
using Validaciones;
using VentaRepuestoPractica.Liberia.Utility;

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
            //foreach (Categoria c in CategoriaListas.)
            ListarCategorias();
            codCategoria = Validador.pedirInt("Ingrese la categoria"); //valido que ingrese correctamente un numero
            Categoria c = CategoriaHelper.GetCategoriaPorCodigo(codCategoria); //me sirve para buscar que el codigo ingresado por usuario EXISTA en la lista de categoria

            //agrego al repuesto la categoria que corresponde una vez que se hicieron las 2 validaciones.
            Repuesto re = new Repuesto(codigo, nombre, precio, stock, c);

            //agrego el repuesto a mi ventaderepuesto disponible
            if(_tiendaRepuestos.AgregarRepuesto(re))
            {
                Console.WriteLine("Se agregó el repuesto: " + re.ToString());
            }
            else
            {
                Console.WriteLine("No se pudo agregar repuesto.");
            }
        }

        private static void ListarCategorias()
        {
            List<Categoria> todas = CategoriaHelper.GetCategorias();
            foreach (Categoria k in todas)
            {
                Console.WriteLine(k.Codigo + " " + k.Nombre);
            }
        }

        private static void EliminarRepuesto()
        {
            //mostrar los repuestos (recorro!!)
            foreach (Repuesto r in _tiendaRepuestos.Lista)
            {
                Console.WriteLine("La lista de repuestos disponible es: " + r.ToString());
            }
            //pedir al usuario que ingrese el codigo de prd que quiere eliminar
            //valido que el codigo este bien escrito y que exista
            //si no tiene stock: se elimina
            //Si tiene stock: no se borra. se manda mensaje
            
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
