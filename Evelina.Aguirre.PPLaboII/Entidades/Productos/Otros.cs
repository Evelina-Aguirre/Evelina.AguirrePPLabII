using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Otros : Producto
    {
        private ECategoriasOtros categoria;
        public Otros(string nombre, short id, int cantidad, double precio, string descripcion) 
            : base(nombre, id, cantidad, precio, descripcion)
        {
        }

        public Otros(string nombre, short id, int cantidad, double precio, string descripcion,ECategoriasOtros categoria)
           : this(nombre, id, cantidad, precio, descripcion)
        {
            this.categoria = categoria;
        }

        public string MostraProducto(Producto p)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(p.MostrarProducto());
            sb.AppendLine($"Categoría: {this.categoria}");

            return sb.ToString();
        }


    }
}
