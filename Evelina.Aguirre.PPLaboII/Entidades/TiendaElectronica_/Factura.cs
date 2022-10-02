using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public abstract class Factura
    {
        private  List<Producto> carrito;
        private EMetodosDePago metodoDePago;
        private double totalCompra;
       
        //private Factura()
        //{
        //    //carrito = new List<Producto>(); -->El carrito se instancia y se completa an el form desde ahí se lo pasan
        //    metodoDePago = EMetodosDePago.efectivo;
        //    totalCompra = 0;
        //}

        public Factura(List<Producto> carrito, EMetodosDePago metodoDePago,double totalCompra) 
        {
            this.carrito = carrito;
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
       

        /// <summary>
        /// Sobrecarga operador +, suma un producto al carro del cliente.
        /// </summary>
        /// <param name="c">carrito</param>
        /// <param name="p">producto</param>
        /// <returns>lista carro del cliente con ese producto agregado y suma el valor al total de la compra</returns>
        public static List<Producto> operator +(Factura c, Producto p)
        {
            foreach (KeyValuePair<int, Producto> item in TiendaDeElectronica.InventarioTienda)
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
        public abstract string MostrarCompra();
        

 


    }
}
