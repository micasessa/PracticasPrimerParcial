using ExpendedoraPracticav2.Libreria.Entidades;
using System.Collections.Generic;

namespace ExpendedoraPracticav2.Libreria.Utilidades
{
    public static class LataHelper
    {
        private static List<Lata> _lista;
        static LataHelper()
        {
            _lista = new List<Lata>();
            Lata lat1 = new Lata("001", "CocaCola", "Coca", 50, 500, 1000);
            Lata lat2 = new Lata("002", "Fanta", "Naranja", 45, 500, 1000);
            Lata lat3 = new Lata("003", "Sprite", "Lima", 55, 500, 1000);

            _lista.Add(lat1);
            _lista.Add(lat2);
            _lista.Add(lat3);
        }
        //des metodos para devolver la lista de lata
        public static List<Lata> GetListaLata()
        {
            return _lista;
        }
        //public static List<Lata> GetLataPorCodigo(string cod)
        //{
        //    Lata resultado = null;
        //    //Busco por cada lata l en la lista de latas
        //    //si el codigo de lata NO coincide con codigo recibido. esta ok
        //    foreach (Lata l in _lista)
        //    {
        //        if (l.Codigo != cod)
        //        {
        //            resultado = l; //el codigo lata buscado NO coincide con la lista 
        //        }
        //        else
        //        { throw new CodigoYaExistenteException(cod); }
                
        //    }
        //    return resultado;

        }
    }

