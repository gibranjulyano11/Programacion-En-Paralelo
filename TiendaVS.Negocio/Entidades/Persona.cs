using System;
using System.Collections.Generic;
using System.Text;

namespace TiendaVS.Negocio.Entidades
{
    public abstract class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime Nacimiento { get; set; }
        protected void MirarProductos()
        {

        }
    }
}
