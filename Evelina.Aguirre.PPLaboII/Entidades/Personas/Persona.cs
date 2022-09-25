using System;

namespace Entidades
{
    public abstract class Persona
    {
        private string nombre;
        private EPersona cargo;

        public Persona(string nombre, EPersona cargo)
        {
            this.nombre = nombre;
            this.cargo=cargo;
        }
        

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public EPersona Cargo
        {
            get
            {
                return this.cargo;
            }
        }
    }
}
