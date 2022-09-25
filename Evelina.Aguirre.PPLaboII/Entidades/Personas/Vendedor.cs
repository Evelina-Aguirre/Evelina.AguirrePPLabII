using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vendedor : Persona
    {
        public Vendedor(string nombre, EPersona cargo) : base(nombre, cargo)
        {
        }
    }
}
