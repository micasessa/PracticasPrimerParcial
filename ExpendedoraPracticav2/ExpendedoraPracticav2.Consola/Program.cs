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
        
        static void Main(string[] args)
        {
            bool _consolaActiva = true;
            Expendedora _maqExpendedora = new Expendedora();
            LataHelper.GetListaLata();

            int opcion;
            do
            {
                Console.WriteLine("Bienvenido");
                DesplegarOpcionesMenu();
                opcion = Validador.pedirInt("Ingrese la opcion que desea");
                switch (opcion)
                {
                    case 0:
                        EncenderMaquina(_maqExpendedora);
                        //El usuario enciende la maquina. Resultado: Maquina encendida.
                        break;
                    case 1:
                        ListarLatasDispoibles(_maqExpendedora);
                        //El usuario pide el listado de latas disponibles.
                        break;
                    case 2:
                        IngresarLata(_maqExpendedora);
                        //El Actor inserta una lata de bebida variable a la máquina.  
                        break;
                    case 3:
                        ExtraerLata(_maqExpendedora);
                        //El Actor elije una lata de la maquina por código, ingresa el dinero y la extrae.                        
                        break;
                    case 4:
                        ObtenerBalance(_maqExpendedora);
                        //El Actor desea conocer el balance
                        break;
                    case 5:
                        MostrarStock(_maqExpendedora);
                        //El Actor desea conocer todo el stock y la descripción completa por cada lata.
                        break;
                    case 6:
                        _consolaActiva = false;
                        break;
                    default:
                        Console.WriteLine("Opcion invalida.");
                        break;
                }
            } while (_consolaActiva);

        }

        private static void EncenderMaquina(Expendedora _maqExpendedora)
        {
            _maqExpendedora.EncenderMaquina();
            Console.WriteLine("La maquina ya está encendida");
        }

        private static void ListarLatasDispoibles(Expendedora _maqExpendedora)
        { //El usuario pide el listado de latas disponibles.
          //Resultado: Se muestra en formato CODIGO) DESCRIPCION[CANTIDAD]
          //Ej.CO1) Coca Cola Regular[5]
            List<Lata> todas = LataHelper.GetListaLata();
            foreach (Lata l in todas)
            {
                Console.WriteLine(l.Codigo + ") " + l.Nombre + "[" + l.Cantidad + "]");
            }
        }

        private static void DesplegarOpcionesMenu()
        {
            Console.WriteLine("******* Menu *******");
            Console.WriteLine("1- Mostra Listas Latas disponibles");
            Console.WriteLine("2- Ingresar lata");
            Console.WriteLine("3- Extraer lata");
            Console.WriteLine("4- Obtener Balance");
            Console.WriteLine("5- Mostrar stock");
            Console.WriteLine("6- Salir");
        }

        static void IngresarLata(Expendedora _maqExpendedora)
        {
            //El Actor inserta una lata de bebida variable a la máquina.
            //Ingresa código, precio, volumen, cantidad (stock), nombre
            //o	Resultado: Se ingresa una lata a la lista de la máquina. Precondiciones:La máquina está encendida
            //Flujo alternativo 1: El código ya existe
            //Flujo alternativo 2: La máquina está llena(capacidad insuficiente)
        }

        static void ExtraerLata(Expendedora _maqExpendedora)
        {
            //El Actor elije una lata de la maquina por código, ingresa el dinero y la extrae.
            //	Se le listan los códigos de las latas(include CU 1)
            //	La lata es seleccionada mediante un código que ingresa el usuario.
            //	El Usuario ingresa dinero que tiene.
            //o Resultado: El usuario obtiene su lata, la maquina acumula dinero y se resta del stock de esa lata
            //o Precondiciones 1: La máquina está encendida.
            //o Precondiciones 2: La lata existe.
            //o Flujo alternativo 1: El código es inválido
            //o Flujo alternativo 2: El dinero no es suficiente
            //o   Flujo alternativo 3: No hay stock de esa lata
        }

        static void ObtenerBalance(Expendedora _maqExpendedora)
        {
            //El Actor desea conocer el balance
            //Resultado: Muestra un string con el dinero que tiene la máquina y cuantas latas tiene.
            //o Precondiciones 1: La máquina está encendida
        }

        static void MostrarStock(Expendedora _maqExpendedora)
        {
            //El Actor desea conocer todo el stock y la descripción completa por cada lata.
            //o Resultado: Muestra por pantalla la lista de las latas, y por cada lata el siguiente string:
            //	  "{nombre} - {sabor} $ {precio} / $/L {precio por litro} - [{cantidad}]"
            //o Precondiciones 1: La máquina está encendida.
            //o Precondiciones 2: La máquina no está vacía.
        }
    }
}
