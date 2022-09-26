using System.Collections.Generic;

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
            : this(carrito, 0, metodoDePago)
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
                return totalCompra;
            }
            set
            {
                totalCompra = value;
            }
        }

        public EMetodosDePago MetodoDePago { get => metodoDePago; set => metodoDePago = value; }
        public double AbonaCon { get => abonaCon; set => abonaCon = value; }
        public double Vuelto { get => vuelto; set => vuelto = value; }


        /// <summary>
        /// Sobrecarga operador +, suma un producto al carro del cliente.
        /// </summary>
        /// <param name="c">carrito</param>
        /// <param name="p">producto</param>
        /// <returns>lista carro del cliente con ese producto agregado y suma el valor al total de la compra</returns>
        public static List<Producto> operator +(Cliente c, Producto p)
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
        public static List<Producto> operator -(Cliente c, Producto p)
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

    }
}
