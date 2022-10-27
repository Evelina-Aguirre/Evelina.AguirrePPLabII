using System;

namespace Entidades.ExcepcionesPropias
{
    public class NumeroFueraDeRangoException : Exception
    {
        public NumeroFueraDeRangoException() : base()
        {
        }
        public NumeroFueraDeRangoException(string mensaje) : base(mensaje)
        {
        }
    }
}
