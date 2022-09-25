﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ComponentesElectronicos : Producto
    {
        public ComponentesElectronicos(string nombre, short id, double precio, string descripcion) 
            : base(nombre, id, precio, descripcion)
        {
        }
    }
}