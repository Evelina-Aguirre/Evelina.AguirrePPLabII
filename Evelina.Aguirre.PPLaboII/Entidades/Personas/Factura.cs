using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Factura
    {
        private List<Producto> carrito;
        private EMetodosDePago metodoDePago;
        private int cantCuotas;
        private double totalCompra;
        private double abonaCon;
        private double vuelto;

        private Factura()
        {
            carrito = new List<Producto>();
            totalCompra = 0;
            metodoDePago = EMetodosDePago.efectivo;
            abonaCon = 0;
        }

        
        public Factura(List<Producto> carrito):this()
        {
            this.carrito = carrito;
        }
        //Contructor casos en debito y crédito
        public Factura(List<Producto> carrito, EMetodosDePago metodoDePago,double totalCompra) : this(carrito) 
        {
            this.metodoDePago = metodoDePago;
            this.totalCompra = totalCompra;
        }
        public Factura(List<Producto> carrito, EMetodosDePago metodoDePago, double totalCompra, int cantCuotas) 
            : this(carrito, metodoDePago, totalCompra)
        {
            this.metodoDePago = metodoDePago;
            this.totalCompra = totalCompra;
            this.cantCuotas = cantCuotas;
        }

        public Factura(List<Producto> carrito, EMetodosDePago metodoDePago, double totalCompra, double abonaCon, double vuelto)
            : this(carrito, metodoDePago, totalCompra, 0)
        {
            this.abonaCon = abonaCon;
            this.vuelto = vuelto;
        }

        public List<Producto> Carrito { get => carrito; set => carrito = value; }

        public double TotalCompra
        {
            get
            {

                if (MetodoDePago is EMetodosDePago.Credito)
                {
                    totalCompra -= (totalCompra * 10) / 100;
                }
                return this.totalCompra;
            }
            set
            {
                this.totalCompra = value;
            }
        }

        public EMetodosDePago MetodoDePago { get => metodoDePago; set => metodoDePago = value; }
        public double AbonaCon
        {
            get
            {
                if(this.MetodoDePago is EMetodosDePago.Credito || this.MetodoDePago is EMetodosDePago.Debito)
                {
                    this.abonaCon = 0;
                }
                return this.abonaCon;
            }
            set
            {
                if (value > 0)
                    this.abonaCon = value;
                else
                    this.abonaCon = 0;
            }
        }
        public double Vuelto 
        {
            get
            {
                return this.vuelto = TiendaElectronica.CalculoVuelto(this);
            }
            set
            {
                this.vuelto = value;
            }
        }


        /// <summary>
        /// Sobrecarga operador +, suma un producto al carro del cliente.
        /// </summary>
        /// <param name="c">carrito</param>
        /// <param name="p">producto</param>
        /// <returns>lista carro del cliente con ese producto agregado y suma el valor al total de la compra</returns>
        public static List<Producto> operator +(Factura c, Producto p)
        {
            foreach (KeyValuePair<int, Producto> item in TiendaElectronica.InventarioTienda)
            {
                if (item.Key == p.Id)
                {
                    c.carrito.Add(item.Value);
                    c.TotalCompra += item.Value.Precio;
                }
            }
            return c.carrito;
        }

        /// <summary>
        /// Sobrecarga de operador -, resta un producto del carro del cliente que se está atendiendo.
        /// </summary>
        /// <param name="c">cliente</param>
        /// <param name="p">producto</param>
        /// <returns>retorna carrito sin ese producto de encontrarlo y resta el valor del mismo al total de la compra</returns>
        public static List<Producto> operator -(Factura c, Producto p)
        {
            if (c.carrito is not null)
            {

                foreach (Producto item in c.Carrito)
                {
                    if (item.Id == p.Id)
                    {
                        c.TotalCompra -= item.Precio;
                        c.Carrito.Remove(item);
                    }
                }
            }
            return c.Carrito;
        }
        
       /// <summary>
       /// 
       /// </summary>
       /// <param name="c"></param>
       /// <returns></returns>
        public string MostrarCompra()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Producto item in this.carrito)
            {
                sb.AppendLine(item.MostrarProducto());
            }
            sb.AppendLine($"Total: {this.TotalCompra}");
            sb.AppendLine($"Metodo de Pago: {this.MetodoDePago.ToString()}");
            sb.AppendLine($"Abona con: {this.AbonaCon}");
            sb.AppendLine($"Vuelto{this.Vuelto}");

            return sb.ToString();
        }

        /// <summary>
        /// Resta el total de la compra del valor con el cual el cliente abona.
        /// </summary>
        /// <param name="c">cliente</param>
        /// <returns>Valor a entregar en concepto de vuelto.</returns>
        

    }
}
