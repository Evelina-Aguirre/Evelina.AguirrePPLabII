using Entidades.ExcepcionesPropias;
using Entidades.TiendaElectronica;
using System.Collections.Generic;
using System.Text;

namespace Entidades.Tienda
{
    public class Estadisticas
    {
        private static List<FacturaDebito> listaFacturas;
        private static List<Producto> listaProductosVendidos;
        private static int cantidadVentas;
        private static double gananciaAcumulada;
        private static int cantidadProdMasVendido;
        static Estadisticas()
        {
            Estadisticas.listaFacturas = new List<FacturaDebito>();
            Estadisticas.ListaProductosVendidos = new List<Producto>();
            Estadisticas.InicializaListaProductosVendidos();
            Estadisticas.cantidadVentas = 0;
            Estadisticas.gananciaAcumulada = 0;
            Estadisticas.cantidadProdMasVendido = 0;
        }

        private static void InicializaListaProductosVendidos()
        {
            Producto auxProducto = new Producto("", 0, 0, "", ECategoriaElectronico.SinCategoria);
            Estadisticas.listaProductosVendidos.Add(auxProducto);
        }

        public static List<FacturaDebito> ListaFacturas { get => listaFacturas; set => listaFacturas = value; }
        public static int CantidadVentas { get => cantidadVentas; set => cantidadVentas = value; }
        public static List<Producto> ListaProductosVendidos { get => listaProductosVendidos; set => listaProductosVendidos = value; }
        public static double GananciaAcumulada { get => gananciaAcumulada; set => gananciaAcumulada = value; }
        public static double CantidadProdMasVendido { get => cantidadProdMasVendido;}

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
                            existe = true;
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
                            item.Value.Descripcion, item.Value.Categoria, 1);
                        Estadisticas.listaProductosVendidos.Add(auxProducto);
                        resultado = true;
                    }
                    break;
                }
            }
            return resultado;
        }

        /// <summary>
        /// Remueve un producto de la lista de Productos vendidos en la tienda a partir del Id
        /// y resta la el precio de este de las ganancias acumuladas.
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

        /// <summary>
        /// Agrupa los productos vendidos por categoría.
        /// </summary>
        /// <param name="categoria"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Informa el nombre del producto más vendido de una categoría determinada.
        /// </summary>
        /// <param name="categoria"></param>
        /// <returns></returns>
        public static string ProductoMasVendido(ECategoriaElectronico categoria)
        {
            List<Producto> productos = new List<Producto>();
            string nombre = "";
            int max = 0;
            productos = ProductosVendidosPorTag(categoria);
            if (productos.Count > 0)
            {
                foreach (Producto item in productos)
                {
                    if (max < item.Cantidad)
                    {
                        max = item.Cantidad;
                        nombre = item.Nombre;
                    }
                }
                Estadisticas.cantidadProdMasVendido = max;
            }
            else
            {
                throw new ListaVaciaException("No se realizaron ventas");
            }

            return nombre;
        }

        /// <summary>
        /// Calcula el promedio del precio de productos vendidos de una categoría.
        /// </summary>
        /// <param name="categoria"></param>
        /// <returns></returns>
        public static double PromedioVentasProducto(ECategoriaElectronico categoria)
        {
            List<Producto> productos = new List<Producto>();
            int contador = 0;
            double promedio = 0;
            double acum = 0;
            productos = ProductosVendidosPorTag(categoria);
            if (productos.Count > 0)
            {
                foreach (Producto item in productos)
                {
                    acum += item.Precio;
                    contador++;
                }
                promedio = acum / contador;
            }
            else
            {
                throw new ListaVaciaException("No se realizaron ventas");
            }
            return promedio;
        }

        public static string Mostrar(ECategoriaElectronico categoria)
        {
            StringBuilder sb = new StringBuilder();
            List<Producto> auxLista = ProductosVendidosPorTag(categoria);

            if (auxLista.Count > 0)
            {

                foreach (Producto item in auxLista)
                {
                    sb.AppendLine(item.MostrarProducto());
                }
            }
            else
            {
                throw new ListaVaciaException("No se realizaron ventas");
            }
            return sb.ToString();
        }

    }
}
