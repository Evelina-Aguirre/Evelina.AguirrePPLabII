using Entidades.Tienda;
using System.Collections.Generic;

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
            TiendaDeElectronica.cuentaTienda = 10000000;
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
            foreach (Producto item in CatalogoProveedor.catalogo)
            {
                TiendaDeElectronica.inventarioTienda.Add(item.Id, item);
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

        public static List<Producto> BuscarProductoPorNombre(string aux)
        {
            List<Producto> auxLista = new List<Producto>();
            
            foreach (KeyValuePair<int, Producto> item in TiendaDeElectronica.InventarioTienda)
            {
                
                if (item.Value.Categoria == Producto.ObtenerCategoriaAPartirDeString(aux) ||
                    item.Value.ToString() == aux)
                {
                    auxLista.Add(item.Value);
                }

            }
            return auxLista;

        }

        //public static Producto BuscarProductoPorId(int id, Dictionary<int, Producto> diccionario)
        //{
        //    foreach (KeyValuePair<int, Producto> item in diccionario)
        //    {
        //        if (id == item.Value.Id)
        //            return item.Value;
        //    }
        //    return null;
        //}
        //public static Producto BuscarProductoPorId(int id, List<Producto> listaProductos)
        //{
        //    foreach (Producto item in listaProductos )
        //    {
        //        if (id == item.Id)
        //            return item;
        //    }
        //    return null;
        //}

        public static double CalculaTotal(double totalActual, double monto, char operacion)
        {
            if (operacion == '+')
            {
                totalActual += monto;
            }
            else if (operacion == '-')
                totalActual -= monto;
            
            return totalActual;
        }


    }
}
