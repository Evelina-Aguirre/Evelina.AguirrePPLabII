using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Productos
{
    public static class Buscador
    {
        /// <summary>
        /// Busca una categoría comparándola con la palabra que se le brinda por parámetro.
        /// </summary>
        /// <param name="categoria"></param>
        /// <returns>categoría del Enumerado ECategoriaElectronico</returns>
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
        /// Busca una categoría (tag) a partir de un string con el nombre de esta.
        /// </summary>
        /// <param name="auxString">categoria en formato string que se va a buscar en el enumerado</param>
        /// <returns>La categoría de encontrarla, caso contrario devolverá "Sincategoria" </returns>
        public static ECategoriaElectronico ObtenerCategoria(string auxString)
        {
            ECategoriaElectronico categoria = ECategoriaElectronico.SinCategoria;

            foreach (ECategoriaElectronico item in Enum.GetValues(typeof(ECategoriaElectronico)))
            {
                if (auxString.ToLower() == item.ToString().ToLower())
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

            foreach (KeyValuePair<int, Producto> item in TiendaDeElectronica.InventarioTienda)
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
        public static List<Producto> CargarProductosPorCategoria(ECategoriaElectronico categoria, Dictionary<int, Producto> diccionario)
        {
            List<Producto> auxListaProductos = new List<Producto>();

            foreach (KeyValuePair<int, Producto> item in diccionario)
            {
                if (item.Value.Categoria.ToString() == categoria.ToString())
                {
                    Buscador.CargarProductosPorCategoria(categoria, auxListaProductos, item.Value);
                }
            }

            return auxListaProductos;

        }


        /// <summary>
        /// Carga Porductos a una lista según la categoría.
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

        /// <summary>
        /// Busca un producto por su nombre en el inventario de la tienda.
        /// </summary>
        /// <param name="aux">Palabra a buscar.</param>
        /// <returns>Lista con los productos encontrados.</returns>
        public static List<Producto> BuscarProducto(string aux)
        {
            List<Producto> auxLista = new List<Producto>();

            foreach (KeyValuePair<int, Producto> item in TiendaDeElectronica.InventarioTienda)
            {

                if (item.Value.Categoria == Buscador.ObtenerCategoria(aux) ||
                    item.Value.ToString() == aux)
                {
                    auxLista.Add(item.Value);
                }

            }
            return auxLista;

        }

        /// <summary>
        /// Busca coincidencias en una colección de tipo diccionario.
        /// </summary>
        /// <param name="aux"></param>
        /// <param name="diccionario"></param>
        /// <returns></returns>
        public static List<Producto> BuscarProducto(string aux, Dictionary<int, Producto> diccionario)
        {
            List<Producto> auxLista = new List<Producto>();
            int auxAInt = 0;
            bool esNumero = int.TryParse(aux, out auxAInt);

            foreach (KeyValuePair<int, Producto> item in diccionario)
            {

                if (item.Value.Categoria == Buscador.ObtenerCategoria(aux) || aux == item.Value.Nombre)
                {
                    auxLista.Add(item.Value);
                }
                else if (esNumero)
                {
                    auxLista.Add(BuscarProducto(auxAInt, diccionario));
                    break;
                }
                string[] array1 = item.Value.Descripcion.Split(' ');
                string[] array2 = item.Value.Nombre.Split(' ');

                for (int i = 0; i < array1.Length; i++)            
                {
                    if(aux.ToLower() == array1[i].ToLower())
                    {
                        auxLista.Add(item.Value);
                    }
                }
                for (int i = 0; i < array2.Length; i++)
                {
                    if (aux.ToLower() == array2[i].ToLower())
                    {
                        auxLista.Add(item.Value);
                    }
                }



            }
            return auxLista;

        }

        /// <summary>
        /// Busca un producto en el inventario de la tienda por id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>El producot de encontrarlo de lo contrario devuelve null.</returns>
        public static Producto BuscarProducto(int id, Dictionary<int, Producto> diccionario)
        {
            Producto auxProducto = null;

            foreach (KeyValuePair<int, Producto> item in diccionario)
            {

                if (item.Value.Id == id)
                {
                    auxProducto = new Producto(item.Value.Nombre, item.Value.Precio, item.Value.Id,
                        item.Value.Descripcion, item.Value.Categoria, item.Value.Cantidad);
                }

            }
            return auxProducto;

        }
    }
}
