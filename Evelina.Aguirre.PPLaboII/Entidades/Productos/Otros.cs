using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Otros :Producto
    {
        //PARA HEREDAD LE FATA ALGUNA PARTICULARIDAD A LA CLASE
        //public Otros(string nombre, int cantidad, double precio, short id, string descripcion)
        //    : base(nombre, cantidad, precio, id, descripcion)
        //{
        //}

        public Otros(string nombre, int cantidad, double precio, short id, string descripcion, ECategoriaElectronico categoria)
           : base(nombre, cantidad, precio, id, descripcion,categoria)
        {

        }

        //public string MostraProducto(Producto p)
        //{
        //    StringBuilder sb = new StringBuilder();
        //    sb.Append(p.MostrarProducto());
        //    sb.AppendLine($"Categoría: {this.categoria.ToString()}");

        //    return sb.ToString();
        //}


    }
}
