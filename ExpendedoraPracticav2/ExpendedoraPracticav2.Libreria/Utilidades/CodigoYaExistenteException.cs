using System;
using System.Runtime.Serialization;

namespace ExpendedoraPracticav2.Libreria.Utilidades
{
    
    public class CodigoYaExistenteException : Exception
    {

        public CodigoYaExistenteException(string message) : base("El codigo ingresado ya existe")
        {
        }

        
    }
}