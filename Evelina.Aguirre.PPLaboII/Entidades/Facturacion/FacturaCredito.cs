using System.Text;

namespace Entidades.TiendaElectronica
{
    public class FacturaCredito : FacturaDebito
    {
        private int cantCuotas;

        public FacturaCredito(EMetodosDePago metodoDePago, double totalCompra, int cantCuotas)
            : base(metodoDePago, totalCompra)
        {
            this.TotalCompra += (this.TotalCompra * 10) / 100;
            this.cantCuotas = cantCuotas;
        }

        /// <summary>
        /// Toma los valores de la factura general y le agraga el concepto de cuotas.
        /// </summary>
        /// <returns></returns>
        protected override string MostrarCompra()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.Append(base.MostrarCompra());
            sb.AppendLine($"Cuotas: {this.cantCuotas}");
            sb.AppendLine("\n Recuerde que se aplica\n" +
                          " un 10 % de recargo a las\n" +
                          " compras en crédito.");

            return sb.ToString();
        }

        /// <summary>
        /// Se sobreescribe el toString() para que al utilizarlo devuelva 
        /// una cadena con los detalles de la factura.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return MostrarCompra();
        }
    }
}
