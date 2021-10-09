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
            CategoriaHelper.GetCategorias();
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
            //mostrar los repuestos
            foreach (Repuesto r in _tiendaRepuestos.Lista)
            {
                Console.WriteLine("La lista de repuestos disponible es: " + r.ToString());
            }
            //pedir al usuario que ingrese el codigo de prd que quiere eliminar
            //valido que el codigo este bien escrito y que exista
            int codigo = Validador.pedirInt("Ingrese el codigo a eliminar");
            Console.WriteLine ("Se va a eliminar el repuesto: "+ _tiendaRepuestos.BuscarPorCodigo(codigo).ToString());
            //Checkeo si tiene o no stock
            if(_tiendaRepuestos.QuitarRepuesto(codigo)) 
            {
                //si no tiene stock: se elimina
                Repuesto eliminado = _tiendaRepuestos.BuscarPorCodigo(codigo);
                Console.WriteLine("El repuesto fue eliminado");
            }else //Si tiene stock: no se borra. se manda mensaje
            {
                Console.WriteLine("Todavia tiene stock. no puede ser eliminado");
            }
        }

        private static void ModificaPrecio()
        {
            //pido al usuario codigo prd + nuevoprecio y lo valido sintacticamente
            int codigo = Validador.pedirInt("Ingrese el codigo del repuesto");
            double nuevoprecio = Validador.pedirDouble("Ingrese el nuevo precio del repuesto");

            //valido que se pueda modificar el precio con un metodo en clase VentaRepuesto
            //valido checkeando que exista el codigo ingresado por el usuario
            if(_tiendaRepuestos.ModificarPrecio(codigo, nuevoprecio))
            {
                Console.WriteLine("Se modifico el precio del nuevo producto: "+ _tiendaRepuestos.BuscarPorCodigo(codigo).ToString());
            } else
            {
                Console.WriteLine("No existe el repuesto del codigo ingresado");
            }
        }

        private static void AgregarStock()
        {   //similar a modificar precio, pero con cantidad
            int codigo = Validador.pedirInt("Ingrese el codigo del repuesto");
            int cantidad = Validador.pedirInt("Ingrese la cantidad del stock del repuesto");
            //valido que se pueda agregar stock con un metodo en clase VentaRepuesto
            //valido checkeando que exista el codigo ingresado por el usuario
            if (_tiendaRepuestos.AgregarStock(codigo, cantidad))
            {
                Console.WriteLine("Se agregó el stock del producto: " + _tiendaRepuestos.BuscarPorCodigo(codigo).ToString());
            }
            else
            {
                Console.WriteLine("No existe el repuesto del codigo ingresado");
            }
        }
        private static void QuitarStock()
        { //Quitar stock de un repuesto
            int codigo = Validador.pedirInt("Ingrese el codigo del repuesto");
            int cantidad = Validador.pedirInt("Ingrese la cantidad del stock del repuesto que desea eliminar");
            //valido que se pueda eliminar stock con un metodo en clase VentaRepuesto
            //valido checkeando que exista el codigo ingresado por el usuario
            if (_tiendaRepuestos.QuitarStock(codigo, cantidad))
            {
                Console.WriteLine("Se quitó el stock del producto: " + _tiendaRepuestos.BuscarPorCodigo(codigo).ToString());
            }
            else
            {
                Console.WriteLine("No existe el repuesto del codigo ingresado");
            }
        }

        private static void ListarRepuesto()
        { //Listar repuestos por categorias
            //pido que ingrese el codigo de la categ al usuario
            int codCategoria = Validador.pedirInt("Ingrese el codigo de la categoria");
            //creo una nueva lista que me traiga los repuestos xcateg que recibe el cod de categ ingresdo por usuario
            List<Repuesto> repuestoPorCateg = _tiendaRepuestos.TraerPorCategoria(codCategoria);
            //Hago un foreach que por cada repuesto encontrado en repuestoPorCateg, me traiga los datos del toString
            foreach (Repuesto r in repuestoPorCateg)
            {
                Console.WriteLine(r.ToString());
            }
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
