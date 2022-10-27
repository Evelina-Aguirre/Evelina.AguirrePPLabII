using Entidades.ExcepcionesPropias;
using Entidades.Productos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.TiendaElectronica
{
    public class Factura
    {
        private static List<Producto> carrito;
        private EMetodosDePago metodoDePago;
        private double totalCompra;

        static Factura()
        {
            carrito = new List<Producto>();
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
                return this.totalCompra;
            }
            set
            {
                double valorAAsignar = 0;
                string aux = value.ToString();
                if(value >= 0 && double.TryParse(aux, out valorAAsignar))
                {
                    this.totalCompra = value;
                }
                else
                {
                    throw new MontoInvalidoException();
                }

            }
        }
        public EMetodosDePago MetodoDePago { get => metodoDePago; set => metodoDePago = value; }

      
        /// <summary>
        /// Agregar un producto a la lista de ítems de la factura y suma el precio del mismo al total.
        /// </summary>
        /// <param name="factura">Factura a modificar del carrito</param>
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
                    foreach (Producto aux in Factura.Carrito)
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
        /// Resta un producto del carro de la factura.
        /// </summary>
        /// <param name="c">cliente</param>
        /// <param name="p">producto</param>
        /// <returns>retorna carrito sin ese producto de encontrarlo y resta el valor del mismo al total de la compra</returns>
        public static bool operator -(Factura factura, int id)
        {
            bool resultado = false;
            bool ultimoItem = false;
            Producto auxProductoARemover= new Producto("",0,0,"",ECategoriaElectronico.SinCategoria,0);
            if (Factura.Carrito is not null)
            {
                foreach (Producto item in Factura.Carrito)
                {
                    if (item.Id == id)
                    {
                        if (item.Cantidad > 1)
                        {
                            factura.TotalCompra -= item.Precio;
                            item.Cantidad--;
                            ultimoItem = false;
                        }
                        else
                        {
                            ultimoItem = true;
                            auxProductoARemover = item;
                        }

                        resultado = true;
                        break;
                    }
                }
                if(ultimoItem)
                {
                    factura.TotalCompra -= auxProductoARemover.Precio;
                    Factura.Carrito.Remove(auxProductoARemover);
                }
            }
            return resultado;

        }

        /// <summary>
        /// Restituye todos los productos del carro de la factura a la tienda.
        /// </summary>
        /// <param name="tienda"></param>
        public static void CancelarCompra(TiendaDeElectronica tienda)
        {
            if (Factura.Carrito is not null)
            {
                foreach (Producto item in FacturaCredito.Carrito)
                {
                    for (int i = 0; i < item.Cantidad; i++)
                    {
                        _ = tienda + item.Id;
                    }
                }
            }
        }

        protected virtual string MostrarCompra()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("TIENDA DE ELECTRÓNICA");
            sb.AppendLine("Factura:");
            sb.AppendLine("Cuit: 30-31212546-9");
            sb.AppendLine(DateTime.Now.ToString() + "\n");
            foreach (Producto item in Factura.Carrito)
            {
                sb.AppendLine(item.MostrarProducto());
            }
            sb.AppendLine($"\nTotal: $ {this.TotalCompra}");
            sb.AppendLine($"Método de Pago: {this.MetodoDePago}");
            return sb.ToString();

        }
        public override string ToString()
        {
            return this.MostrarCompra();
        }

    }
}
