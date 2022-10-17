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
        /// Muestra propiedades del producto.
        /// </summary>
        /// <returns>String con la descripción del producto</returns>
        public string MostrarProducto()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Tag: {this.Categoria} ");
            sb.AppendLine($"{this.Nombre} - Cant.: {this.cantidad}");
            sb.AppendLine($"Precio: {this.Precio}");

            return sb.ToString();
        }



    }
}
