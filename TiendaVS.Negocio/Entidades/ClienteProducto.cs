namespace TiendaVS.Negocio.Entidades
{
    public class ClienteProducto
    {
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public int ProductoId { get; set; }
        public Producto Producto { get; set; }
    }
}
