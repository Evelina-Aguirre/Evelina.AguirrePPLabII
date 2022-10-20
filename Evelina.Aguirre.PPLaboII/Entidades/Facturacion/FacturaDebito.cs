using Entidades.Productos;
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

        /// <summary>
        /// Agregar un producto a la lista de ítems de la factura y suma el precio del mismo al total.
        /// </summary>
        /// <param name="factura">Factura a modificarcarrito</param>
        /// <param name="p">Producto a agregar</param>
        /// <returns>Factura con el producto agregado y el precio de este sumado al total.</returns>
        public static FacturaDebito operator +(FacturaDebito factura, Producto p)
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
                    foreach (Producto aux in FacturaDebito.Carrito)
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
                        FacturaDebito.Carrito.Add(p);
                        factura.TotalCompra += p.Precio;
                    }
                }

            }

            return factura;
        }

        /// <summary>
        /// Sobrecarga de operador -, resta un producto del carro de la factura.
        /// </summary>
        /// <param name="c">cliente</param>
        /// <param name="p">producto</param>
        /// <returns>retorna carrito sin ese producto de encontrarlo y resta el valor del mismo al total de la compra</returns>
        public static bool operator -(FacturaDebito factura, int id)
        {
            bool resultado = false;
            bool ultimoItem = false;
            Producto auxProductoARemover= new Producto("",0,0,"",ECategoriaElectronico.SinCategoria,0);
            if (Factura.Carrito is not null)
            {
                foreach (Producto item in FacturaDebito.Carrito)
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
            if(FacturaDebito.Carrito is not null)
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

        /// <summary>
        /// Muestra los detalles de la factura.
        /// </summary>
        /// <returns></returns>
        public override string MostrarCompra()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Producto item in Factura.Carrito)
            {
                sb.AppendLine(item.MostrarProducto());
            }
            sb.AppendLine($"\nTotal: {base.TotalCompra}");
            sb.AppendLine($"Metodo de Pago: {base.MetodoDePago}");

            return sb.ToString();
        }
        public override string ToString()
        {
            return this.MostrarCompra();
        }

    }
}
