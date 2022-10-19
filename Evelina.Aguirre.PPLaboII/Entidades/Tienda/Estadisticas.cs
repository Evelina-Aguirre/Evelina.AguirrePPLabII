using Entidades.TiendaElectronica;
using System.Collections.Generic;

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
            Estadisticas.listaFacturas = new List<FacturaDebito>();
            Estadisticas.ListaProductosVendidos = new List<Producto>();
            Estadisticas.InicializaListaProductosVendidos();
            Estadisticas.cantidadVentas = 0;
            Estadisticas.gananciaAcumulada = 0;
        }

        private static void InicializaListaProductosVendidos()
        {
            Producto auxProducto = new Producto("", 0, 0, "", ECategoriaElectronico.SinCategoria);
            Estadisticas.listaProductosVendidos.Add(auxProducto);
        }

        //public Estadisticas(List<FacturaDebito> listaFacturas, List<Producto> listaProductosVendidos, int cantidadVentas, double gananciaAcumulada)
        //{
        //    Estadisticas.listaFacturas = listaFacturas;
        //    Estadisticas.listaProductosVendidos = listaProductosVendidos;
        //    Estadisticas.cantidadVentas = cantidadVentas;
        //    Estadisticas.gananciaAcumulada = gananciaAcumulada;
        //}


        public static List<FacturaDebito> ListaFacturas { get => listaFacturas; set => listaFacturas = value; }
        public static int CantidadVentas { get => cantidadVentas; set => cantidadVentas = value; }
        public static List<Producto> ListaProductosVendidos { get => listaProductosVendidos; set => listaProductosVendidos = value; }
        public static double GananciaAcumulada { get => gananciaAcumulada; }

        /// <summary>
        /// Agrega producto y precio de este a los atributos de la estadística.
        /// </summary>
        /// <param name="estadistica"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool operator +(Estadisticas estadistica, int id)
        {
            bool resultado = false;
            bool existe = true;

            foreach (KeyValuePair<int, Producto> item in TiendaDeElectronica.InventarioTienda)
            {
                if (item.Value.Id == id)
                {
                    foreach (Producto aux in Estadisticas.ListaProductosVendidos)
                    {
                        if (aux.Id == id)
                        {
                            aux.Cantidad++;
                            gananciaAcumulada += item.Value.Precio;
                            resultado = true;
                            break;
                        }
                        else
                        {
                            existe = false;
                        }
                    }
                        
                    if (!existe)
                    {
                        Producto auxProducto = new Producto(item.Value.Nombre, item.Value.Precio, item.Value.Id,
                            item.Value.Descripcion, item.Value.Categoria,1);
                        Estadisticas.listaProductosVendidos.Add(auxProducto);
                        gananciaAcumulada += item.Value.Precio;
                        resultado = true;
                    }
                    break;
                }
            }
            return resultado;
        }

        /// <summary>
        /// Remueve un producto de la lista de Productos vendidos en la tienda a partir del Id.
        /// </summary>
        /// <param name="estadistica"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool operator -(Estadisticas estadistica, int id)
        {
            bool resultado = false;

            if (Estadisticas.ListaProductosVendidos is not null)
            {
                foreach (Producto item in Estadisticas.ListaProductosVendidos)
                {
                    if (item.Id == id)
                    {
                        gananciaAcumulada -= item.Precio;
                        if (item.Cantidad < 1)
                        {
                            item.Cantidad--;
                        }
                        else
                        {
                            Estadisticas.ListaProductosVendidos.Remove(item);
                        }

                        resultado = true;
                        break;
                    }

                }
            }
            return resultado;
        }

        public static List<Producto> ProductosVendidosPorTag(ECategoriaElectronico categoria)
        {
            List<Producto> auxListaProducto = new List<Producto>();
            foreach (Producto item in Estadisticas.listaProductosVendidos)
            {
                if (item.Categoria == categoria)
                {
                    auxListaProducto.Add(item);
                }

            }
            return auxListaProducto;
        }

        public static string ProductoMasVendido(ECategoriaElectronico categoria)
        {
            List<Producto> productos = new List<Producto>();
            string nombre = "";
            int max = 1;
            productos = ProductosVendidosPorTag(categoria);
            foreach (Producto item in productos)
            {
                if (max < item.Cantidad)
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
            double promedio = 0;
            double acum = 0;
            productos = ProductosVendidosPorTag(categoria);
            foreach (Producto item in productos)
            {
                acum += item.Precio;
                contador++;
            }
            promedio = acum / contador;

            return promedio;
        }



    }
}
