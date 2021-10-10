using System;
using System.Runtime.Serialization;

namespace ExpendedoraPracticav2.Libreria.Utilidades
{
    
    public class CodigoInvalidoException : Exception
    {

        public CodigoInvalidoException(string message) : base("El codigo ingresado ya existe")
        {
        }

        
    }
}