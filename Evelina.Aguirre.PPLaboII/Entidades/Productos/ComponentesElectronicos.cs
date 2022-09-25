using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ComponentesElectronicos : Producto
    {
        private ECategoriaElectronico categoria;
        public ComponentesElectronicos(string nombre, short id, int cantidad, double precio, string descripcion) 
            : base(nombre, id, cantidad, precio, descripcion)
        {
        }

        public ComponentesElectronicos(string nombre, short id, double precio, int cantidad, string descripcion, ECategoriaElectronico categoria)
            : this(nombre, id, cantidad, precio, descripcion)
        {
            this.categoria = categoria;
        }
    }
}
