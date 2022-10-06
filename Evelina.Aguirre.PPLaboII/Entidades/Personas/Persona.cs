using System;

namespace Entidades
{
    public class Persona
    {
        private string usuario;
        private string clave;
        private EPersona cargo;

        public Persona(string usuario,string clave, EPersona cargo)
        {
            this.usuario = usuario;
            this.clave = clave;
            this.cargo=cargo;
        }
        

        public string Usuario
        {
            get
            {
                return this.usuario;
            }
        }

        public string Clave
        {
            get
            {
                return this.clave;
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
