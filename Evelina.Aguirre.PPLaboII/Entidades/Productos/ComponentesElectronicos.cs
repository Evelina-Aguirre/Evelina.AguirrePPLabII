using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ComponentesElectronicos :Producto
    {
        public ComponentesElectronicos(string nombre, int cantidad, double precio, int id, string descripcion,ECategoriaElectronico categoria)
            : base(nombre, cantidad, precio, id,descripcion,categoria)
        {

        }


    }
}
