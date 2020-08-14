using System.Collections.Generic;

namespace TiendaVS.Negocio.Entidades
{
    public class Producto
    {
        public int ProductoId { get; set; }
        public string Nombre { get; set; }
        public List<ClienteProducto> ClienteProductos { get; set; } = new List<ClienteProducto>();
    }
}
