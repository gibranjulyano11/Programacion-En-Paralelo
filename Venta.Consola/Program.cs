using System;
using TiendaVS.Negocio;
using TiendaVS.Negocio.Entidades;

namespace Venta.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola soy Arleth!");
            Console.WriteLine("Te mostraté una letra de una canción, espero que sea de tu agrado");
            Console.WriteLine();

            Cliente cliente = new Cliente
            {
                Nombre = "Gibrán",
                Apellido = "Guzmán",
                Nacimiento = new DateTime(2000, 11, 10)
            };
            Producto producto = new Producto
            {
                Nombre = "Camiseta Zero"
            };
            Producto producto1 = new Producto
            {
                Nombre = "Pantalón Zero"
            };
            Vendedor vendedor = new Vendedor();
            vendedor.Vender(cliente, producto);

            Vendedor vendedor1 = new Vendedor();
            vendedor1.Vender(cliente, producto1);

           // Console.WriteLine($"Hay {Vendedor.Vendidos } productos vendidos");
            
            Console.WriteLine("Letra de la canción: Rock Me Baby");
            var gestor = new LetraCancion();
            var ruta = @"C:\Users\gibra\OneDrive\Documentos\Gorky\TiendaVS.Negocio\TiendaVS.Negocio\Entidades\letra.txt";
            var contenido = gestor.Leer(ruta);
            Console.WriteLine("Artista: BB King");
            Console.WriteLine(contenido);
        }
    }
}

