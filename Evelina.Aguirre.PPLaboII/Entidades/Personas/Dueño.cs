﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Dueño : Persona
    {
        public Dueño(string usuario,string clave, EPersona cargo) : base(usuario,clave, cargo)
        {

        }
    }
}
