using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.TiendaElectronica
{
    public class FacturaEfectivo : FacturaCredito
    {
        private double abonaCon;
        private double vuelto;
        public FacturaEfectivo(List<Producto> carrito, EMetodosDePago metodoDePago, double totalCompra, int cantCuotas,double abonaCon, double vuelto) 
            : base(carrito, metodoDePago, totalCompra, cantCuotas)
        {
            this.abonaCon = abonaCon;
            this.vuelto = vuelto;
        }

        public override string MostrarCompra()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.MostrarCompra());
            sb.AppendLine($"Abona con: {this.abonaCon}");
            sb.AppendLine($"Vuelto: {this.vuelto}");

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.MostrarCompra();
        }
    }
}
