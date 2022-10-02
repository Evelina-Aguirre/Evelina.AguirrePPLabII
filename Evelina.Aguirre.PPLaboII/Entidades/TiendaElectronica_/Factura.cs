using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Factura
    {
        private static List<Producto> carrito;
        private EMetodosDePago metodoDePago;
        private double totalCompra;

        static Factura()
        {
            Factura.carrito = new List<Producto>();
        }
      
        public Factura(EMetodosDePago metodoDePago,double totalCompra)
        {
            this.metodoDePago = metodoDePago;
            this.totalCompra = totalCompra;
        }
        

        public List<Producto> Carrito { get => carrito; set => carrito = value; }

        public double TotalCompra
        {
            get
            {

                if (MetodoDePago is EMetodosDePago.Credito)
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
       
        /// <summary>
        /// Agregar un producto a la lista de ítems de la factura y suma el precio del mismo al total.
        /// </summary>
        /// <param name="factura">Factura a modificarcarrito</param>
        /// <param name="p">Producto a agregar</param>
        /// <returns>Factura con el producto agregado y el precio de este sumado al total.</returns>
        public static Factura operator +(Factura factura, Producto p)
        {
            foreach (KeyValuePair<int, Producto> item in TiendaDeElectronica.InventarioTienda)
            {
                if (item.Value == p)
                {
                    factura.Carrito.Add(item.Value);
                    factura.TotalCompra += item.Value.Precio;
                }
            }
            return factura;
        }

        /// <summary>
        /// Sobrecarga de operador -, resta un producto del carro del cliente que se está atendiendo.
        /// </summary>
        /// <param name="c">cliente</param>
        /// <param name="p">producto</param>
        /// <returns>retorna carrito sin ese producto de encontrarlo y resta el valor del mismo al total de la compra</returns>
        public static Factura operator -(Factura factura, Producto p)
        {
            if (factura.Carrito is not null)
            {

                foreach (Producto item in factura.Carrito)
                {
                    if (item.Id == p.Id)
                    {
                        factura.TotalCompra -= item.Precio;
                        factura.Carrito.Remove(item);
                    }
                }
            }
            return factura;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public virtual string MostrarCompra()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Producto item in this.Carrito)
            {
                sb.AppendLine(item.MostrarProducto());
            }
            sb.AppendLine($"\nTotal: {this.TotalCompra}");
            sb.AppendLine($"Metodo de Pago: {this.MetodoDePago}");

            return sb.ToString();

        }






    }
}
