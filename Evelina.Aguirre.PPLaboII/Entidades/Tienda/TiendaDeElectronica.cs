﻿using Entidades.ExcepcionesPropias;
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
            TiendaDeElectronica.cuentaTienda = 500000;
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
                if (value >= 0 && value < double.MaxValue)
                {
                    TiendaDeElectronica.cuentaTienda = value;
                }
                else
                {
                    throw new NumeroFueraDeRangoException("Valor fuera de rango.");
                }
            }
        }

        /// <summary>
        /// Incrementa la cantidad de un producto en el inventario de la tienda.
        /// </summary>
        /// <param name="tienda"></param>
        /// <param name="id"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Disminuye la cantidad de un producto en el inventario de la tienda.
        /// </summary>
        /// <param name="tienda"></param>
        /// <param name="id"></param>
        /// <returns></returns>
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
            Persona duenio = new Persona("Dueño", "Dueño", EPersona.Dueño);
            Persona vendedor = new Persona ("Vendedor", "Vendedor", EPersona.Vendedor);
            Persona contador = new Persona("contador", "contador", EPersona.Contador);
            usuariosApp.Add(duenio);
            usuariosApp.Add(vendedor);
            usuariosApp.Add(contador);
        }

        /// <summary>
        /// Carga la lista de inventario desde el catálogo del proveedor.
        /// </summary>
        public static void CargarProductosEnStock()
        {
            int nuevaKey = 2000;
            
            foreach (KeyValuePair<int, Producto> item in CatalogoProveedor.catalogo)
            {
                nuevaKey++;
                Producto auxProducto = new Producto(item.Value.Nombre,item.Value.Precio, item.Value.Id,
                    item.Value.Descripcion, item.Value.Categoria,10);
                TiendaDeElectronica.inventarioTienda.Add(nuevaKey, auxProducto);   
            }
            
        }

        /// <summary>
        /// Busca en los usuarios previamente registrados en la aplicación e informa a qué perfil pertenece. 
        /// /// </summary>
        /// <param name="usuario"></param>
        /// <param name="clave"></param>
        /// <returns>si la persona que se loguea está registrado como dueño, administrados o desconocido</returns>
        public static EPersona Logueo(string usuario, string clave)
        {
            EPersona cargo = EPersona.Desconocido;

            if (!string.IsNullOrEmpty(usuario) && !string.IsNullOrEmpty(clave))
            {
                foreach (Persona auxPersona in usuariosApp)
                {
                    if (auxPersona.Usuario.Trim().ToLower() == usuario.Trim().ToLower() &&
                         auxPersona.Clave.Trim().ToLower() == clave.Trim().ToLower())
                    {
                        cargo = auxPersona.Cargo;
                    }
                }
            }
            return cargo;
        }
    }
}
