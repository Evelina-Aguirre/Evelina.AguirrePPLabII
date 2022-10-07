using Entidades.TiendaElectronica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Tienda
{
    public class Estadisticas
    {


        private static List<FacturaDebito> listaFacturas;
        private static List<Producto> listaProductosVendidos;
        private static int cantidadVentas;
        private static double gananciaAcumulada;



        static Estadisticas()
        {
            listaFacturas = new List<FacturaDebito>();
            ListaProductosVendidos = new List<Producto>();
            cantidadVentas = 0;
            gananciaAcumulada = 0;
        }


        public static List<FacturaDebito> ListaFacturas { get => listaFacturas; set => listaFacturas = value; }
        public static int CantidadVentas { get => cantidadVentas; set => cantidadVentas = value; }
        public static List<Producto> ListaProductosVendidos { get => listaProductosVendidos; set => listaProductosVendidos = value; }


        /// <summary>
        /// Agrega producto y precio de este a los atributos de la estadística.
        /// </summary>
        /// <param name="estadistica"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool operator +(Estadisticas estadistica, int id)
        {
            bool resultado = false;
            
            if (Estadisticas.ListaProductosVendidos is not null)
            {
                foreach (KeyValuePair<int,Producto> item in TiendaDeElectronica.InventarioTienda)
                {
                    if (item.Value.Id == id)
                    {
                        gananciaAcumulada += item.Value.Precio;
                        Estadisticas.listaProductosVendidos.Add(item.Value);
                    }

                }
            }
            return resultado;
        }

        /// <summary>
        /// Remueve un producto de la lista de Productos Vendidos en la tienda a partie del Id.
        /// </summary>
        /// <param name="estadistica"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool operator -(Estadisticas estadistica, int id)
        {
            bool resultado = false;
            if (Estadisticas.ListaProductosVendidos is not null)
            {
                foreach ( Producto item in Estadisticas.ListaProductosVendidos)
                {
                    if (item.Id == id)
                    {
                        gananciaAcumulada -= item.Precio;
                        Estadisticas.listaProductosVendidos.Remove(item);
                    }

                }
            }
            return resultado;
        }

        public static List<Producto> ProductosVendidosPorTag(ECategoriaElectronico categoria)
        {
            List<Producto> auxListaProducto = new List<Producto>();
            foreach (Producto item in listaProductosVendidos)
            {
                if(item.Categoria == categoria)
                {
                    auxListaProducto.Add(item);
                }

            }
                return auxListaProducto;

        }

        public static string ProductoMasVendido(ECategoriaElectronico categoria)
        {
            List<Producto> productos = new List<Producto>();
            int cantidad=0;
            string nombre = "";
            int max = 1;
            productos = ProductosVendidosPorTag(categoria);
            foreach (Producto item in productos)
            {
                if(item.Cantidad > max )
                {
                    max = item.Cantidad;
                    nombre = item.Nombre;
                }
            }

            return nombre;
        }

        public static double PromedioVentasProducto(ECategoriaElectronico categoria)
        {
            List<Producto> productos = new List<Producto>();
            int contador = 0;
            double promedio=0;
            double acum = 0;
            productos = ProductosVendidosPorTag(categoria);
            foreach (Producto item in listaProductosVendidos)
            {
                acum += item.Precio;
                contador++;
            }
            promedio = acum / contador;
            
            return promedio;

        }



    }
}
