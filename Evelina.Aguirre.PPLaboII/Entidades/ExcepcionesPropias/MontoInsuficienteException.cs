using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ExcepcionesPropias
{
    public class MontoInsuficienteException:Exception
    {
        public MontoInsuficienteException():base()
        {
                
        }
        public MontoInsuficienteException(string mensaje) : base(mensaje)
        {
        }
    }
    
}
