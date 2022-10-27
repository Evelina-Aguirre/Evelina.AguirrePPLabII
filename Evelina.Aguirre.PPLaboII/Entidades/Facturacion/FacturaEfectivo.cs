using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.TiendaElectronica
{
    public class FacturaEfectivo : Factura
    {
        private double abonaCon;
        private double vuelto;

        public FacturaEfectivo( EMetodosDePago metodoDePago, double totalCompra,double abonaCon) 
            : base(metodoDePago, totalCompra)
        {
            this.abonaCon = abonaCon;
            this.vuelto = this.Vuelto;
        }

        public double AbonaCon
        {
            get
            {
                return this.abonaCon;
            }
            set
            {
                this.abonaCon = value;
            }
        }

        public double Vuelto
        {
            get
            {
                return CalculoVuelto(base.TotalCompra, this.AbonaCon);
            }
        }

        /// <summary>
        /// Calcula el vuelto a partir de el monto con el cual se abona y el total.
        /// </summary>
        /// <param name="totalCompra"></param>
        /// <param name="abonaCon"></param>
        /// <returns>Monto en concepto de vuelto</returns>
        public static double CalculoVuelto(double totalCompra, double abonaCon)
        {
            double vuelto = 0;

            if (abonaCon > 0 && totalCompra > 0 && abonaCon >= totalCompra)
            {
                vuelto = abonaCon - totalCompra;
            }

            return vuelto;
        }

        /// <summary>
        /// Toma los valores de la factura general y detalla con cuanto se abona 
        /// y el monto que se debe devolver en concepto de vuelto.
        /// </summary>
        /// <returns></returns>
        protected override string MostrarCompra()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.MostrarCompra());
            sb.AppendLine($"Abona con: $ {this.abonaCon}");
            sb.AppendLine($"Vuelto: $ {Math.Round(this.vuelto,2)}");
            return sb.ToString();
        }

        /// <summary>
        /// Se sobreescribe el toString() para que al utilizarlo devuelva 
        /// una cadena con los detalles de la factura.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.MostrarCompra();
        }
    }
}
