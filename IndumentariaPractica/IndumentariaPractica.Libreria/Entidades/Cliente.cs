using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndumentariaPractica.Libreria.Utilidades;

namespace IndumentariaPractica.Libreria.Entidades
{
    public class Cliente
    {
        public int Codigo;
        public string Apellido;
        public string Nombre;

        //no declaro las propiedades porque las variables son publicas
        //Declaro constructores
        public Cliente() { }
        public Cliente (int codigo, string apellido, string nombre)
        {
            Codigo = codigo;
            Apellido = apellido;
            Nombre = nombre;
        }

    }
}
