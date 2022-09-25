using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        private List<Producto> carrito;
        private double totalCompra;
        private EMetodosDePago metodoDePago;
        private double abonaCon;
        private double vuelto;

        public Cliente(List<Producto> carrito, double totalCompra, EMetodosDePago metodoDePago)
        {
            this.carrito = carrito;
            this.totalCompra = totalCompra;
            this.metodoDePago = metodoDePago;
        }

        public Cliente(List<Producto> carrito, double totalCompra, EMetodosDePago metodoDePago, double abonaCon, double vuelto)
            : this(carrito, totalCompra, metodoDePago)
        {
            this.abonaCon = abonaCon;
            this.vuelto = vuelto;
        }

        public List<Producto> Carrito { get => carrito; set => carrito = value; }
        
        public double TotalCompra
        {
            get
            {

                if(this.MetodoDePago is EMetodosDePago.Credito)
                {
                    this.totalCompra -= (this.totalCompra * 10) / 100; 
                }
                return this.totalCompra;
            }
            set
            {
                this.totalCompra = value;
            }
        }

        public EMetodosDePago MetodoDePago { get => metodoDePago; set => metodoDePago = value; }
        public double AbonaCon { get => abonaCon; set => abonaCon = value; }
        public double Vuelto { get => vuelto; set => vuelto = value; }




    }
}
