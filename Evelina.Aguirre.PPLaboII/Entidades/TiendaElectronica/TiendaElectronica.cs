using Entidades.Tienda;
using System.Collections.Generic;

namespace Entidades
{
    public class TiendaElectronica
    {

        private static List<Persona> usuariosApp;
        private static Dictionary<int, Producto> inventarioTienda;
        private static double cuentaTienda;
       

        static TiendaElectronica()
        {
            usuariosApp = new List<Persona>();
            TiendaElectronica.inventarioTienda = new Dictionary<int, Producto>();
            TiendaElectronica.cuentaTienda = 10000000;
            CargarUsuariosRegistradosEnApp();
            CargarProductosEnStock();
        }
        
        public static Dictionary<int, Producto> InventarioTienda 
        {
            get
            {
                return TiendaElectronica.inventarioTienda;
            }
            set
            {
                TiendaElectronica.inventarioTienda = value;
            }
        }

        public static double CuentaTienda
        {
            get
            {
                return TiendaElectronica.cuentaTienda;
            }
            set
            {
                TiendaElectronica.cuentaTienda = value;
            }
        }
        
        /// <summary>
        /// Carga usuarios previamente registrados en la aplicación.
        /// </summary>
        public static void CargarUsuariosRegistradosEnApp()
        {
            Dueño duenio = new Dueño("dueño", "dueño", EPersona.Dueño);
            Vendedor vendedor = new Vendedor("vend", "vend", EPersona.Vendedor);
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
                TiendaElectronica.inventarioTienda.Add(item.Id,item);
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
        /// Resta el total de la compra del monto con el que el cliente abona.
        /// </summary>
        /// <param name="c">Cliente</param>
        /// <returns>Monto a devolver en concepto de vuelto</returns>
        public static double CalculoVuelto(Cliente c)
        {
            double vuelto = 0;
            if (c.MetodoDePago is EMetodosDePago.efectivo)
            {
                if (c.AbonaCon > 0 && c.TotalCompra > 0 && c.AbonaCon > c.TotalCompra)
                {
                    vuelto = c.AbonaCon - c.TotalCompra;
                }
            }
            return vuelto;
        }



       

    }
}
