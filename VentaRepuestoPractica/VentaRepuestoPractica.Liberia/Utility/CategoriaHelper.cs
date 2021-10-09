using System.Collections.Generic;
using VentaRepuestoPractica.Libreria.Entidades;

namespace VentaRepuestoPractica.Liberia.Utility
{
    public static class CategoriaHelper
    {
        //Para listar las categorias y ordenarlas
        private static List<Categoria> _lista;

        //desarrollo constructor
        //Cargo datos de categorias y las agrego a la lista
        static CategoriaHelper()
        {
            _lista = new List<Categoria>(); //Inicializo
            
            Categoria cat1 = new Categoria(1, "Ruedas"); //creo Lista
            Categoria cat2 = new Categoria(2, "Accesorio");
            Categoria cat3 = new Categoria(1, "Motor");

            _lista.Add(cat1); //Agrego elementos a la lista
            _lista.Add(cat2);
            _lista.Add(cat3);
        }

        //metodoS que me devuelven la lista de categorias
        //OPCION A)
        public static List<Categoria> GetCategorias() { return _lista; }

        //metodo para tener categoria por codigo (solo el codigo que corresponde). Opcion B
        public static Categoria GetCategoriaPorCodigo(int cod)
        {
            Categoria resultado = null;
            //Busco por cada categoria c en la lista de categorias
            //si el codigo de categoria coincide con codigo recibido. esta ok
            foreach (Categoria c in _lista)
            {
                if (c.Codigo == cod)
                {
                    resultado = c; //la categoria buscada coincide con la 
                }
            }
            return resultado;
        }
    }
}
