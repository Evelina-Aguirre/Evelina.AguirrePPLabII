using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.TiendaElectronica
{
    public class FacturaDebito: Factura
    {

        public FacturaDebito(List<Producto> carrito, EMetodosDePago metodoDePago, double totalCompra)
           : base(carrito, metodoDePago, totalCompra)
        {
            
        }

        public override string MostrarCompra()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Producto item in base.Carrito)
            {
                sb.AppendLine(item.MostrarProducto());
            }
            sb.AppendLine($"Total:          {base.TotalCompra}");
            sb.AppendLine($"Metodo de Pago: {base.MetodoDePago}");
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.MostrarCompra();
        }

        

    }
}
