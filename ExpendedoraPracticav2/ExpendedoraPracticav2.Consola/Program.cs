using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpendedoraPracticav2.Libreria.Entidades;
using ExpendedoraPracticav2.Libreria.Utilidades;
using Validaciones;

namespace ExpendedoraPracticav2.Consola
{
    class Program
    {
        static bool _consolaActiva;
        static Expendedora _maqExpendedora;

        static Program()
        {
            _consolaActiva = true;
            _maqExpendedora = new Expendedora("CocaCola Company", 20000, 5000);
        }
        static void Main(string[] args)
        {
            while (_consolaActiva)
            {
                Console.Clear();
                Console.WriteLine("Bienvenido a la expendedora de " + _maqExpendedora.Proveedor);                
                DesplegarOpcionesMenu();
                string opcion = Validador.pedirString("Ingrese la opcion que desea");
                switch (opcion)
                {
                    case "0":
                        //El usuario enciende la maquina. Resultado: Maquina encendida.
                        Program.EncenderMaquina(_maqExpendedora);                        
                        break;
                    case "1":
                        //El usuario pide el listado de latas disponibles.
                        Program.ListarLatasDispoibles(_maqExpendedora);                        
                        break;
                    case "2":
                        Program.IngresarLata(_maqExpendedora);
                        //El Actor inserta una lata de bebida variable a la máquina.  
                        break;
                    case "3":
                        Program.ExtraerLata(_maqExpendedora);
                        //El Actor elije una lata de la maquina por código, ingresa el dinero y la extrae.                        
                        break;
                    case "4":
                        Program.ObtenerBalance(_maqExpendedora);
                        //El Actor desea conocer el balance
                        break;
                    case "5":
                        Program.MostrarStock(_maqExpendedora);                        
                        //El Actor desea conocer todo el stock y la descripción completa por cada lata.
                        break;
                    case "6":
                        _consolaActiva = false;
                        break;
                    default:
                        Console.WriteLine("Opcion invalida.");
                        break;
                }
                Console.WriteLine("presione una tecla para salir");
                Console.ReadLine();
            }

        }
        
        private static void EncenderMaquina(Expendedora _maqExpendedora)
        {
            _maqExpendedora.EncenderMaquina();
            Console.WriteLine("La maquina ya está encendida");
        }

        private static void ListarLatasDispoibles(Expendedora _maqExpendedora)
        { //El usuario pide el listado de latas disponibles.
          //Resultado: Se muestra en formato CODIGO) DESCRIPCION[CANTIDAD]. Ej.CO1) Coca Cola Regular[5]
            //primero me fijo si la maquina esta vacia o no:
            if(_maqExpendedora.EstaVacia() == true)
            {
                Console.WriteLine("La maquina está vacia. debe ingresar latas");
            } else
            {
                List<Lata> todas = LataHelper.GetListaLata();
                foreach (Lata l in todas)
                {
                    Console.WriteLine(l.Codigo + ") " + l.Nombre + "[" + l.Cantidad + "]");
                }
            }

            
        }

        private static void DesplegarOpcionesMenu()
        {
            Console.WriteLine("Menu: ");
            Console.WriteLine("0-Encienda la maquina");
            Console.WriteLine("1- Mostra Listas Latas disponibles");
            Console.WriteLine("2- Ingresar lata");
            Console.WriteLine("3- Extraer lata");
            Console.WriteLine("4- Obtener Balance");
            Console.WriteLine("5- Mostrar stock");
            Console.WriteLine("6- Salir");
        }

        static void IngresarLata(Expendedora _maqExpendedora)
        {
            if (_maqExpendedora.Encendida == true) //Precondiciones:La máquina está encendida
            {   //Resultado: Se ingresa una lata a la lista de la máquina.
                try //intento que la maquina haga todo lo que está adentro de estos {}
                {
                    //El Actor inserta una lata de bebida variable a la máquina.Ingresa código, precio, volumen, cantidad (stock), nombre
                    string cod;
                    double precio;
                    string nombre;
                    string sabor;
                    double volumen;
                    int cantidad;
                    //yo:pido al usuario que ingrese las variables
                    cod = Validador.pedirString("Ingrese el codigo");
                    nombre = Validador.pedirString("Ingrese el nombre");
                    sabor = Validador.pedirString("Ingrese el sabor");
                    precio = Validador.pedirDouble("Ingrese el precio");
                    volumen = Validador.pedirDouble("Ingrese el volumen");
                    cantidad = Validador.pedirInt("Ingrese la cantidad");

                    //buscar que no exista el cod ingresado por usuario en mi maquina. si existe: mandar mensaje que no se puede agregar. else: add lata a la maquina
                    //antes del add. meto otro if controlando la CAPACIDAD de la maquina: si se llego al max: no se puede agregar(mje), else: add lata
                                        
                    Lata lata1 = new Lata(cod, nombre, sabor, precio, volumen, cantidad);
                    _maqExpendedora.AgregarLata(lata1);
                } catch (CodigoInvalidoException ex) //Flujo alternativo 1: El código ya existe
                { 
                    Console.WriteLine(ex.Message); 
                }
                catch(CapacidadInsuficienteException ex) //Flujo alternativo 2: La máquina está llena(capacidad insuficiente)
                {
                    Console.WriteLine(ex.Message);
                }
                
            } else
            {
                Console.WriteLine("La maquina esta apagada");
            }
        }

        static void ExtraerLata(Expendedora _maqExpendedora)
        {   //o Resultado: El usuario obtiene su lata, la maquina acumula dinero y se resta del stock de esa lata
            if (_maqExpendedora.Encendida == true) //o Precondiciones 1: La máquina está encendida.
            {
                try
                {
                    //El Actor elije una lata de la maquina por código, ingresa el dinero y la extrae.
                    //Usuario ingresa el codigo de la lata + dinero que va a ingresar
                    string codAIngresar = Validador.pedirString("Ingrese el codigo de la lata");
                    double dineroAIngresar = Validador.pedirDouble("Ingrese la cantidad de dinero");

                    //"Mando" a libreria los valores ingresados por el usuario para que valide si existe
                    Lata lataExtraida = _maqExpendedora.ExtraerLata(codAIngresar, dineroAIngresar);
                    Console.WriteLine("La lata fue extraida");
                     
                }
                catch (CodigoInvalidoException ex) //o Flujo alternativo 1: El código es inválido + //o Precondiciones 2: La lata existe
                {
                    Console.WriteLine(ex.Message);
                }
                catch (DineroInsuficienteException ex)//o Flujo alternativo 2: El dinero no es suficiente
                {
                    Console.WriteLine(ex.Message);
                }
                catch (SinStockException ex) //o   Flujo alternativo 3: No hay stock de esa lata
                {
                    Console.WriteLine(ex.Message);
                }

            } else
            {
                Console.WriteLine ("La maquina esta apagada");
            }
        }

        static void ObtenerBalance(Expendedora _maqExpendedora)
        {
            if(_maqExpendedora.Encendida == true) //o Precondiciones 1: La máquina está encendida
            {
                //El Actor desea conocer el balance
                //Resultado: Muestra un string con el dinero que tiene la máquina y cuantas latas tiene.
                Console.WriteLine(_maqExpendedora.GetBalance());
            }
            else
            {
                Console.WriteLine("La maquina esta apagada");
            } 
        }

        static void MostrarStock(Expendedora _maqExpendedora)
        {   //o Precondiciones 1: La máquina está encendida. //o Precondiciones 2: La máquina no está vacía.
            if (_maqExpendedora.Encendida == true && _maqExpendedora.EstaVacia() == false) 
            {   //El Actor desea conocer todo el stock y la descripción completa por cada lata.                
                Console.WriteLine(_maqExpendedora.Latas.ToString());
            }
            else
            {
                Console.WriteLine("La maquina esta apagada");
            }
        }
    }
}
