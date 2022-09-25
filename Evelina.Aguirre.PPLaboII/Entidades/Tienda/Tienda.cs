using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Tienda
    {
        private static Dictionary<int, Producto> inventarioTienda;
        private static Dictionary<int, Producto> catalogoProductos;//Proveedor
        private static double cuentaTienda;

        static Tienda()
        {
            Tienda.inventarioTienda = new Dictionary<int, Producto>();
            Tienda.catalogoProductos = new Dictionary<int, Producto>();
            Tienda.cuentaTienda = 1000000;
        }

    }
}
