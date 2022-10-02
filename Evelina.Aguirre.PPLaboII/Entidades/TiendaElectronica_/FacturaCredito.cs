using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.TiendaElectronica
{
    public class FacturaCredito : FacturaDebito
    {
        private int cantCuotas;
        public FacturaCredito(List<Producto> carrito, EMetodosDePago metodoDePago, double totalCompra, int cantCuotas) 
            : base(carrito,metodoDePago,totalCompra)
        {
            this.cantCuotas = cantCuotas;
        }
        public override string MostrarCompra()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.MostrarCompra());
            sb.AppendLine($"Cuotas:{this.cantCuotas}");
            
            //Todavía no me pide set porque hasta ahora no necesito geetear las cuotas desde ningun lado solo desde acá

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.MostrarCompra();
        }
    }
}
