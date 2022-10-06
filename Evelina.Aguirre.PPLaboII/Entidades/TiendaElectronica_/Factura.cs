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

        public Factura(EMetodosDePago metodoDePago, double totalCompra)
        {
            this.metodoDePago = metodoDePago;
            this.totalCompra = totalCompra;
        }


        public static List<Producto> Carrito { get => carrito; set => carrito = value; }

        public double TotalCompra
        {
            get
            {
                if (MetodoDePago is EMetodosDePago.Credito)
                {
                    totalCompra -= (totalCompra * 10) / 100;
                }
                return totalCompra;
            }
            set
            {
                totalCompra = value;
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
            int existe = 0;
            if (Factura.Carrito is null || Factura.Carrito.Count == 0)
            {
                Factura.Carrito.Add(p);
                factura.TotalCompra += p.Precio;
                return factura;
            }

            foreach (KeyValuePair<int, Producto> item in TiendaDeElectronica.InventarioTienda)
            {
                if (item.Value == p)
                {
                    foreach (Producto aux in  Factura.Carrito)
                    {
                        if (aux == p)
                        {
                            aux.Cantidad++;
                            factura.TotalCompra += p.Precio;
                            existe = 1;
                        }
                        else
                        {
                            existe = 0;
                        }
                        
                    }
                    if (existe == 0)
                    {
                       Factura.Carrito.Add(p);
                       factura.TotalCompra += p.Precio;
                    }
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
        public static bool operator -(Factura factura, int id)
        {
            bool resultado = false;
            if (Factura.Carrito is not null)
            {
                foreach (Producto item in Factura.Carrito)
                {
                    if (item.Id == id)
                    {
                        factura.TotalCompra -= item.Precio;
                        if (item.Cantidad == 1)
                        {
                            Factura.Carrito.Remove(item);
                        }
                        else
                        {
                            item.Cantidad--;
                        }
                        resultado = true;
                        break;
                    }
                }
            }
            return resultado;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public virtual string MostrarCompra()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Producto item in Factura.Carrito)
            {
                sb.AppendLine(item.MostrarProducto());
            }
            sb.AppendLine($"\nTotal: {TotalCompra}");
            sb.AppendLine($"Metodo de Pago: {MetodoDePago}");

            return sb.ToString();

        }






    }
}
