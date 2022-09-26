using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Producto
    {

        private string nombre;
        private short id;
        private int cantidad;
        private double precio;
        private string descripcion;

        public Producto(string nombre, short id, int cantidad, double precio, string descripcion)
        {
            this.nombre = nombre;
            this.id = id;
            this.cantidad = cantidad;
            this.precio = precio;
            this.descripcion = descripcion;
        }

        public short Id { get => id;}
        public string Nombre { get => nombre;}
        public int Cantidad { get => cantidad; }
        public double Precio { get => precio;}
        public string Descripcion { get => descripcion;}

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
       /// Muestra propiedades del producto.
       /// </summary>
       /// <returns>string con la descripción del producto</returns>
        public string MostrarProducto()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Id:{this.Id}");
            sb.AppendLine($"Nombre : {this.Nombre}");
            sb.AppendLine($"Cantidad: {this.cantidad}");
            sb.AppendLine($"Precio: {this.Precio}");

            return sb.ToString();
        }
    }
}
