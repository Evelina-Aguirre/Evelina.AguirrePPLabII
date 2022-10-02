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
        public FacturaEfectivo( EMetodosDePago metodoDePago, double totalCompra, int cantCuotas,double abonaCon) 
            : base(metodoDePago, totalCompra, cantCuotas)
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
        public static double CalculoVuelto(double totalCompra, double abonaCon)
        {
            double vuelto = 0;

            if (abonaCon > 0 && totalCompra > 0 && abonaCon >= totalCompra)
            {
                vuelto = abonaCon - totalCompra;
            }

            return vuelto;
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
