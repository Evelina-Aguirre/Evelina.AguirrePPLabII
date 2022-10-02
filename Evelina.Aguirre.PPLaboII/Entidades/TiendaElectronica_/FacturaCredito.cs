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
            sb.Append($"Cuotas:          {this.cantCuotas}");

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.MostrarCompra();
        }
    }
}
