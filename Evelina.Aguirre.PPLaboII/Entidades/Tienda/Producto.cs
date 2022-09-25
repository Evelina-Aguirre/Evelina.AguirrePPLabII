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
        private double precio;
        private string descripcion;

        public Producto(string nombre, short id, double precio, string descripcion)
        {
            this.nombre = nombre;
            this.id = id;
            this.precio = precio;
            this.descripcion = descripcion;
        }
        //Se podrá hacer un enumerado de enumerados
        //o una lista o diccionario o algo dónde poner enumerados


    }
}
