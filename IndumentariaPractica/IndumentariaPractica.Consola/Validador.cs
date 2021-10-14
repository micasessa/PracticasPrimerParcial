using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validaciones
{
    public class Validador
    {
        public static int pedirMenu(string mensaje)
        {
            int opcMenu = 0;
            do
            {
                Console.WriteLine(mensaje);
                if (!int.TryParse(Console.ReadLine(), out opcMenu))
                {
                    opcMenu = -1;
                }
                if (opcMenu != 1 && opcMenu != 2 && opcMenu != 3 && opcMenu != 4 && opcMenu != 5)
                {
                    Console.WriteLine("Ingrese una opcion valida");
                }
            } while (opcMenu != 1 && opcMenu != 2 && opcMenu != 3 && opcMenu != 4 && opcMenu != 5);
            return (opcMenu);
        }
        public static string pedirString(string mensaje)
        {
            string retorno = "";
            do
            {
                Console.WriteLine(mensaje);
                retorno = Console.ReadLine();
                if (retorno == "")
                {
                    Console.WriteLine("El string no puede estar vacio");
                }
            } while (retorno == "");
            return (retorno);
        }
        public static int pedirInteger(string mensaje, int minimo, int maximo)
        {
            int numero = minimo - 1;
            bool pudeConvertir;

            do
            {
                Console.WriteLine(mensaje);
                pudeConvertir = Int32.TryParse(Console.ReadLine(), out numero);
                if (pudeConvertir)
                {
                    if (numero < minimo || numero > maximo)
                    {
                        Console.WriteLine(mensaje);
                    }
                }
                else
                {
                    Console.WriteLine("Debe ingresar un valor numerico");
                    numero = minimo - 1;
                }
            } while (numero < minimo || numero > maximo);

            return numero;
        }

        public static int pedirInt(string mensaje)
        {
            int numero = 0;
            bool pudeConvertir = true;

            do
            {
                Console.WriteLine(mensaje);
                pudeConvertir = Int32.TryParse(Console.ReadLine(), out numero);
                if (pudeConvertir)
                {
                    if (numero > 0)
                    {
                        pudeConvertir = true;
                    }
                }
                else
                {
                    Console.WriteLine("Debe ingresar un valor numerico");
                }
            } while (!pudeConvertir && numero > 0);

            return numero;
        }
        public static double pedirDouble(string mensaje)
        {
            double retorno = 0;
            bool valido = false;
            do
            {
                Console.WriteLine(mensaje);
                valido = Double.TryParse(Console.ReadLine(), out retorno);
                if (!valido)
                {
                    Console.WriteLine("Debe ingresar un numero");
                }
            } while (!valido);
            return (retorno);
        }
    }
}
