using System.Text;

namespace Entidades.TiendaElectronica
{
    public class FacturaCredito : FacturaDebito
    {
        private int cantCuotas;

        public FacturaCredito(EMetodosDePago metodoDePago, double totalCompra, int cantCuotas)
            : base(metodoDePago, totalCompra)
        {
            this.totalCompra += (this.totalCompra * 10) / 100;
            this.cantCuotas = cantCuotas;
        }

        //public override double TotalCompra
        //{
        //    get
        //    {
        //        return base.totalCompra;
        //    }
        //    set
        //    {
        //        if (this.MetodoDePago is EMetodosDePago.Credito)
        //        {
        //            double resultado = 0;
        //            resultado += (value * 10) / 100;
        //            value = resultado;
        //        }
        //        this.totalCompra = value;
        //    }
        //}


        /// <summary>
        /// Toma los valores de la factura general y le agraga el concepto de cuotas.
        /// </summary>
        /// <returns></returns>
        public override string MostrarCompra()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.Append(base.MostrarCompra());
           
            if (cantCuotas == 0)
            {
                sb.AppendLine($"Cuotas: --");
            }
            else
            {
                sb.AppendLine($"Cuotas: {this.cantCuotas}");
            }

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
