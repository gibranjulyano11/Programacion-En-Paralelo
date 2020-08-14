using TiendaVS.Negocio.Entidades;

namespace TiendaVS.Negocio
{
    public class Vendedor
    {
        public static int Vendidos { get; set; }
        public void Vender(Cliente cliente, Producto producto)
        {
            cliente.ClienteProductos.Add(new ClienteProducto
            {
                Producto=producto,
                Cliente=cliente
            });
            Vendidos++;
        }
    }
}
