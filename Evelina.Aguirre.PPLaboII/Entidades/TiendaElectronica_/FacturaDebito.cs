using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.TiendaElectronica
{
    public class FacturaDebito: Factura
    {

        public FacturaDebito(EMetodosDePago metodoDePago, double totalCompra)
           : base( metodoDePago, totalCompra)
        {
            
        }

        public override string MostrarCompra()
        {
            return base.ToString();
        }

        public override string ToString()
        {
            return this.MostrarCompra();
        }

        public static FacturaDebito operator +(FacturaDebito factura, Producto p)
        {
            foreach (KeyValuePair<int, Producto> item in TiendaDeElectronica.InventarioTienda)
            {
                if (item.Value == p)
                {
                    factura.Carrito.Add(item.Value);
                    factura.TotalCompra += item.Value.Precio;
                }
            }
            return factura;
        }

        public static FacturaDebito operator -(FacturaDebito factura, Producto p)
        {
            if (factura.Carrito is not null)
            {

                foreach (Producto item in factura.Carrito)
                {
                    if (item.Id == p.Id)
                    {
                        factura.TotalCompra -= item.Precio;
                        factura.Carrito.Remove(item);
                    }
                }
            }
            return factura;
        }



    }
}
