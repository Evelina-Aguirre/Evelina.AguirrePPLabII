using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {

        private string nombre;
        private int cantidad;
        private double precio;
       private int id;
        private string descripcion;
        private ECategoriaElectronico categoria;

        public Producto(string nombre, double precio, int id, string descripcion, ECategoriaElectronico categoria)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.id = id;
            this.descripcion = descripcion;
            this.categoria = categoria;
        }

        public Producto(string nombre, double precio, int id, string descripcion, ECategoriaElectronico categoria, int cantidad) 
            : this(nombre,precio,id,descripcion,categoria)
        {
            this.cantidad = cantidad;
        }


        public string Nombre { get => nombre;}
        public int Cantidad { get => cantidad; set => cantidad = value;} 
        public double Precio { get => precio; set => precio = value; }
        public string Descripcion { get => descripcion;}
        public ECategoriaElectronico Categoria { get => categoria; set => categoria = value; }
       public int Id { get => id; set => id = value; }

        
        /// <summary>
        /// Compara dos productos por Id.
        /// </summary>
        /// <param name="p1">Producto 1</param>
        /// <param name="p2">Producto 2</param>
        /// <returns>retorna true si los Id de los productos son iguales</returns>
        public static bool operator ==(Producto p1, Producto p2)
        {
            return p1.Id == p2.Id;
        }

        /// <summary>
        /// Compara dos productos por Id.
        /// </summary>
        /// <param name="p1">Producto 1</param>
        /// <param name="p2">Producto 2</param>
        /// <returns>Devuelve true si los productos tienen diferente Id</returns>
        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

        /// <summary>
        /// Método toString sobreescrito, devuelve nombre del producto.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.nombre;
        }

        /// <summary>
        /// Busca una categoría (tag) a partir de un string con el nombre de esta.
        /// </summary>
        /// <param name="auxString">categoria en formato string que se va a buscar en el enumerado</param>
        /// <returns>La categoría de encontrarla, caso contrario devolverá "Sincategoria" </returns>
        public static ECategoriaElectronico ObtenerCategoria(string auxString)
        {
            ECategoriaElectronico categoria = ECategoriaElectronico.SinCategoria;

            foreach (ECategoriaElectronico item in Enum.GetValues(typeof(ECategoriaElectronico)))
            {
                if(auxString.ToLower() == item.ToString().ToLower())
                {
                    categoria = item;
                    break;
                }

            }
            return categoria;
        }

        /// <summary>
        /// Informa la categoría de un producto a partir de su ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Categoría buscada o "sin categoría de no encontrar el ID"</returns>
        public static ECategoriaElectronico ObtenerCategoria(int id)
        {
            ECategoriaElectronico categoria = ECategoriaElectronico.SinCategoria;

            foreach (KeyValuePair<int,Producto> item in TiendaDeElectronica.InventarioTienda)
            {
                if (item.Value.Id == id)
                {
                    categoria = item.Value.Categoria;
                    break;
                }

            }
            return categoria;
        }
        /// <summary>
        /// Busca en una colección Diccionario la categoría que se especifica por parámetro.
        /// </summary>
        /// <param name="categoria">categoría/tag que se busca</param>
        /// <returns>Diccionario cargado con la categoría que se busca</returns>
        public static List<Producto> CargarProductosPorCategoria(ECategoriaElectronico categoria, Dictionary<int,Producto> diccionario)
        {
            List<Producto> auxListaProductos = new List<Producto>();
           
            foreach (KeyValuePair<int, Producto> item in diccionario)
            {
                if (item.Value.Categoria.ToString() == categoria.ToString())
                {
                    Producto.CargarProductosPorCategoria(categoria, auxListaProductos, item.Value);
                }
            }

            return auxListaProductos;

        }

        /// <summary>
        /// Busca en una colección de tipo lista una categoría.
        /// </summary>
        /// <param name="categoria"></param>
        /// <param name="lista"></param>
        /// <returns>Lista con todos los elementos encontrados con esa categoría.</returns>
        public static List<Producto> CargarProductosPorCategoria(ECategoriaElectronico categoria, List<Producto> lista)
        {
            List<Producto> auxListaProductos = new List<Producto>();

            foreach (Producto item in lista)
            {
                if (item.Categoria.ToString() == categoria.ToString())
                {
                    Producto.CargarProductosPorCategoria(categoria, auxListaProductos, item);
                }
            }

            return auxListaProductos;

        }

        /// <summary>
        /// Carga un Porductos a una lista según la categoría.
        /// </summary>
        /// <param name="categoria"></param>
        /// <param name="lista"></param>
        /// <param name="item"></param>
        /// <returns>Lista cargada con los productos que se encontraron de esa categoría.</returns>
        private static List<Producto> CargarProductosPorCategoria(ECategoriaElectronico categoria, List<Producto> lista, Producto item)
        {
            switch (categoria)
            {
                case ECategoriaElectronico.Leds:
                    lista.Add(item);
                    break;
                case ECategoriaElectronico.Bobinas:
                    lista.Add(item);
                    break;
                case ECategoriaElectronico.Capacitores:
                    lista.Add(item);
                    break;
                case ECategoriaElectronico.Conectores:
                    lista.Add(item);
                    break;
                case ECategoriaElectronico.CircuitosIntegrados:
                    lista.Add(item);
                    break;
                case ECategoriaElectronico.Plaquetas:
                    lista.Add(item);
                    break;
                case ECategoriaElectronico.Soldado:
                    lista.Add(item);
                    break;
                case ECategoriaElectronico.Limpieza:
                    lista.Add(item);
                    break;
                case ECategoriaElectronico.Herramientas:
                    lista.Add(item);
                    break;
                case ECategoriaElectronico.ControlTermico:
                    lista.Add(item);
                    break;

            }
            return lista;
        }


        public static ECategoriaElectronico StringAECategoriaElectronico(string categoria)
        {
            ECategoriaElectronico resultadoCategoria = ECategoriaElectronico.SinCategoria;
            switch (categoria)
            {
                case "Leds":
                    resultadoCategoria = ECategoriaElectronico.Leds;
                    break;
                case "Bobinas":
                    resultadoCategoria = ECategoriaElectronico.Bobinas;
                    break;
                case "Capacitores":
                    resultadoCategoria = ECategoriaElectronico.Capacitores;
                    break;
                case "Conectores":
                    resultadoCategoria = ECategoriaElectronico.Conectores;
                    break;
                case "CircuitosIntegrados":
                    resultadoCategoria = ECategoriaElectronico.CircuitosIntegrados;
                    break;
                case "Plaquetas":
                    resultadoCategoria = ECategoriaElectronico.Plaquetas;
                    break;
                case "Soldado":
                    resultadoCategoria = ECategoriaElectronico.Soldado;
                    break;
                case "Limpieza":
                    resultadoCategoria = ECategoriaElectronico.Limpieza;
                    break;
                case "Herramientas":
                    resultadoCategoria = ECategoriaElectronico.Herramientas;
                    break;
                case "ControlTermico":
                    resultadoCategoria = ECategoriaElectronico.ControlTermico;
                    break;

            }

            return resultadoCategoria;
        }


        /// <summary>
        /// Muestra propiedades del producto.
        /// </summary>
        /// <returns>String con la descripción del producto</returns>
        public string MostrarProducto()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Tag: {this.Categoria} ");
            sb.AppendLine($"{this.Nombre}  - Cant.: {this.cantidad}");

            sb.AppendLine($"Precio: {this.Precio}");

            return sb.ToString();
        }



    }
}
