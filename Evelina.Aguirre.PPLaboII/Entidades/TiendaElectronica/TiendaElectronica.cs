using Entidades.Tienda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TiendaElectronica
    {
        private static Dictionary<int, Producto> inventarioTienda;
        private static double cuentaTienda;

        static TiendaElectronica()
        {
            TiendaElectronica.inventarioTienda = new Dictionary<int, Producto>();
            TiendaElectronica.cuentaTienda = 10000000;
            CargarProductosEnStock();
        }

        public static Dictionary<int, Producto> InventarioTienda { get => inventarioTienda; set => inventarioTienda = value; }
        public static double CuentaTienda { get => cuentaTienda; set => cuentaTienda = value; }

        public static void CargarProductosEnStock()
        {
            foreach (Producto item in CatalogoProveedor.Catalogo)
            {
                TiendaElectronica.inventarioTienda.Add(item.Id,item);
            }
        }




    }
}
