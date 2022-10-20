using System;

namespace Entidades.ExcepcionesPropias
{
    public class ListaVaciaException : Exception
    {
        public ListaVaciaException() : base()
        {

        }
        public ListaVaciaException(string mensaje) : base(mensaje)
        {
        }
    }
}
