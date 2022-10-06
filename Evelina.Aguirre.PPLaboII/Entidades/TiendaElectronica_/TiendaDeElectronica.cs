using Entidades.Tienda;
using System.Collections.Generic;
using System.Linq;

namespace Entidades
{
    public class TiendaDeElectronica
    {

        private static List<Persona> usuariosApp;
        private static Dictionary<int, Producto> inventarioTienda;
        private static double cuentaTienda;


        static TiendaDeElectronica()
        {
            usuariosApp = new List<Persona>();
            TiendaDeElectronica.inventarioTienda = new Dictionary<int, Producto>();
            TiendaDeElectronica.cuentaTienda = 5000000;
            CargarUsuariosRegistradosEnApp();
            CargarProductosEnStock();
        }


        public static Dictionary<int, Producto> InventarioTienda
        {
            get
            {
                return TiendaDeElectronica.inventarioTienda;
            }
            set
            {
                TiendaDeElectronica.inventarioTienda = value;
            }
        }

        public static double CuentaTienda
        {
            get
            {
                return TiendaDeElectronica.cuentaTienda;
            }
            set
            {
                TiendaDeElectronica.cuentaTienda = value;
            }
        }

        public static bool operator +(TiendaDeElectronica tienda, int id)
        {
            bool resultado = false;
            if (TiendaDeElectronica.InventarioTienda is not null)
            {
                foreach (KeyValuePair<int, Producto> item in TiendaDeElectronica.InventarioTienda)
                {
                    if (item.Value.Id == id)
                    {
                        item.Value.Cantidad++;
                        resultado = true;
                        break;
                    }
                }
            }
            return resultado;

        }


        public static bool operator -(TiendaDeElectronica tienda, int id)
        {
            bool resultado = false;
            if (TiendaDeElectronica.InventarioTienda is not null)
            {
                foreach (KeyValuePair<int, Producto> item in TiendaDeElectronica.InventarioTienda)
                {
                    if (item.Value.Id == id)
                    {
                        if (item.Value.Cantidad > 0)
                        {
                            item.Value.Cantidad--;
                            resultado = true;
                            break;
                        }
                        else
                        {
                            TiendaDeElectronica.InventarioTienda.Remove(item.Key);
                            resultado = true;
                            break;
                        }
                    }

                }
            }
            return resultado;
        }

        /// <summary>
        /// Carga usuarios previamente registrados en la aplicación.
        /// </summary>
        public static void CargarUsuariosRegistradosEnApp()
        {
            Dueño duenio = new Dueño("d", "d", EPersona.Dueño);
            Vendedor vendedor = new Vendedor("v", "v", EPersona.Vendedor);
            usuariosApp.Add(duenio);
            usuariosApp.Add(vendedor);
        }

        /// <summary>
        /// Carga los productos con los que cuanta la tienda.
        /// </summary>
        public static void CargarProductosEnStock()
        {
            int nuevaKey = 2000;
            //Carga la lista de inventario desde el catálogo del proveedor
            foreach (KeyValuePair<int, Producto> item in CatalogoProveedor.catalogo)
            {
                Producto auxProducto = new Producto(item.Value.Nombre,item.Value.Precio, item.Value.Id,
                    item.Value.Descripcion, item.Value.Categoria,10);
                TiendaDeElectronica.inventarioTienda.Add(nuevaKey++, auxProducto);
                
                    //foreach (KeyValuePair<int, Producto> aux in TiendaDeElectronica.inventarioTienda)
                    //{
                    //    if(item.Value == aux.Value)
                    //    {
                    //        aux.Value.Cantidad = 10;
                    //    }
                    //}
                
            }
            
        }

        /// <summary>
        /// Busca en los usuarios previamente registrados en la aplicación e informa a que perfil pertenece. 
        /// /// </summary>
        /// <param name="usuario"></param>
        /// <param name="clave"></param>
        /// <returns>si la persona que se loguea está registrado como dueño, administrados o desconocido</returns>
        public static EPersona Logueo(string usuario, string clave)
        {
            if (!string.IsNullOrEmpty(usuario) && !string.IsNullOrEmpty(clave))
            {
                foreach (Persona auxPersona in usuariosApp)
                {
                    if (auxPersona.Usuario.Trim().ToLower() == usuario.Trim().ToLower() &&
                         auxPersona.Clave.Trim().ToLower() == clave.Trim().ToLower())
                    {
                        return auxPersona.Cargo;
                    }
                }
            }
            return EPersona.Desconocido;
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

                if (item.Value.Categoria == Producto.ObtenerCategoria(aux) ||
                    item.Value.ToString() == aux)
                {
                    auxLista.Add(item.Value);
                }

            }
            return auxLista;

        }

       


    }
}
