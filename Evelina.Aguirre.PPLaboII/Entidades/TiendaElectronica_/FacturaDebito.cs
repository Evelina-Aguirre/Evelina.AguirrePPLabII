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

        public override string ToString()
        {
            return base.MostrarCompra();
        }


    }
}
