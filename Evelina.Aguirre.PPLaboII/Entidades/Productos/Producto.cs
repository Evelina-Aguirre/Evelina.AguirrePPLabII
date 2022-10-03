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
        private short id;
        private string descripcion;
        private ECategoriaElectronico categoria;

        public Producto(string nombre, int cantidad, double precio, short id)
        {
            this.nombre = nombre;
            this.cantidad = cantidad;
            this.precio = precio;
            this.id = id;
        }
        public Producto(string nombre, int cantidad, double precio, short id, string descripcion, ECategoriaElectronico categoria)
            :this(nombre, cantidad,precio,id)
        {
            this.nombre = nombre;
            this.cantidad = cantidad;
            this.precio = precio;
            this.id = id;
            this.descripcion = descripcion;
            this.categoria = categoria;
        }


        public short Id { get => id;}
        public string Nombre { get => nombre;}
        public int Cantidad { get => cantidad; }
        public double Precio { get => precio;}
        public string Descripcion { get => descripcion;}
        public ECategoriaElectronico Categoria { get => categoria; /*set => categoria = value; */}


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
        public static ECategoriaElectronico ObtenerCategoriaAPartirDeString(string auxString)
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
        /// Busca en el inventario de la tienda la categoría que se especifica por parámetro.
        /// </summary>
        /// <param name="categoria">categoría/tag que se busca</param>
        /// <returns>Diccionario cargado con la categoría que se busca</returns>
        public static List<Producto> CargarProductosPorCategoria(ECategoriaElectronico categoria)
        {
            List<Producto> auxListaProductos = new List<Producto>();
           
            foreach (KeyValuePair<int, Producto> item in TiendaDeElectronica.InventarioTienda)
            {
                if (item.Value.Categoria.ToString() == categoria.ToString())
                {
                    switch (categoria)
                    {
                        case ECategoriaElectronico.Leds:
                            auxListaProductos.Add(item.Value);
                            break;
                        case ECategoriaElectronico.Bobinas:
                            auxListaProductos.Add(item.Value);
                            break;
                        case ECategoriaElectronico.Capacitores:
                            auxListaProductos.Add(item.Value);
                            break;
                        case ECategoriaElectronico.Conectores:
                            auxListaProductos.Add(item.Value);
                            break;
                        case ECategoriaElectronico.CircuitosIntegrados:
                            auxListaProductos.Add(item.Value);
                            break;
                        case ECategoriaElectronico.Plaquetas:
                            auxListaProductos.Add(item.Value);
                            break;
                        case ECategoriaElectronico.Soldado:
                            auxListaProductos.Add(item.Value);
                            break;
                        case ECategoriaElectronico.Limpieza:
                            auxListaProductos.Add(item.Value);
                            break;
                        case ECategoriaElectronico.Herramientas:
                            auxListaProductos.Add(item.Value);
                            break;
                        case ECategoriaElectronico.ControlTermico:
                            auxListaProductos.Add(item.Value);
                            break;

                    }
                }
            }

            return auxListaProductos;

        }

        
        /// <summary>
        /// Muestra propiedades del producto.
        /// </summary>
        /// <returns>string con la descripción del producto</returns>
        public string MostrarProducto()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Tag: {this.Categoria} -- Id: {this.Id}");
            sb.AppendLine($"{this.Nombre}  - Cant.: {this.cantidad}");

            sb.AppendLine($"Precio: {this.Precio}");

            return sb.ToString();
        }



    }
}
