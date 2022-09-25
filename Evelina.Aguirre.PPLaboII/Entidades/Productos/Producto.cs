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
        private short id;
        private int cantidad;
        private double precio;
        private string descripcion;

        public Producto(string nombre, short id, int cantidad, double precio, string descripcion)
        {
            this.nombre = nombre;
            this.id = id;
            this.precio = precio;
            this.descripcion = descripcion;
        }

        public string Nombre { get => nombre;}
        public short Id { get => id;}
        public double Precio { get => precio;}
        public string Descripcion { get => descripcion;}
    }
}
