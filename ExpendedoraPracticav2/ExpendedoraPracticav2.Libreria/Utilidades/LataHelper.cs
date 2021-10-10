using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpendedoraPracticav2.Libreria.Entidades;

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

    }
}
