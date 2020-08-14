using System.Collections.Generic;

namespace TiendaVS.Negocio.Entidades
{
    public class Cliente : Persona
    {
        public int ClienteId { get; set; }
        public List<ClienteProducto> ClienteProductos { get; set; } = new List<ClienteProducto>();
        public void Comprar()
        {
            base.MirarProductos();
        }
    }
}
