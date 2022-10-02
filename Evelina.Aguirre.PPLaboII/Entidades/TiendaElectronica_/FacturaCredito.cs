using System.Text;

namespace Entidades.TiendaElectronica
{
    public class FacturaCredito : FacturaDebito
    {
        private int cantCuotas;
        public FacturaCredito(EMetodosDePago metodoDePago, double totalCompra, int cantCuotas)
            : base(metodoDePago, totalCompra)
        {
            this.cantCuotas = cantCuotas;
        }
        public override string MostrarCompra()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.Append(base.MostrarCompra());
           
            if (cantCuotas == 0)
            {
                sb.AppendLine($"Cuotas:-");
            }
            else
            {
                sb.AppendLine($"Cuotas:{cantCuotas}");
            }

            return sb.ToString();
        }

        public override string ToString()
        {
            return MostrarCompra();
        }
    }
}
