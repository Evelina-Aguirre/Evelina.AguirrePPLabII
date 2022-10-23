using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public abstract class Factura
    {
        private static List<Producto> carrito;
        private EMetodosDePago metodoDePago;
        internal double totalCompra;

        static Factura()
        {
            carrito = new List<Producto>();
        }

        public Factura(EMetodosDePago metodoDePago, double totalCompra)
        {
            this.metodoDePago = metodoDePago;
            this.totalCompra = totalCompra;
        }


        public  static List<Producto> Carrito
        {
            get
            {
                return carrito;
            }
            set
            {
                Factura.carrito = value;
            }
        }

        public double TotalCompra
        {
            get
            {
                return this.totalCompra;
            }
            set
            {
                this.totalCompra = value;
            }
        }

        public EMetodosDePago MetodoDePago { get => metodoDePago; set => metodoDePago = value; }


        public abstract string MostrarCompra();
      








    }
}
