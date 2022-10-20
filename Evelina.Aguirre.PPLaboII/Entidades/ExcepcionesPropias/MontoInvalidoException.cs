using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ExcepcionesPropias
{
   public  class MontoInvalidoException : Exception
    {
        public MontoInvalidoException():base()
        {
                
        }
        public MontoInvalidoException(string mensaje) : base(mensaje)
        {
        }
    }
}
