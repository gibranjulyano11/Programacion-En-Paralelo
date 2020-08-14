using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using TiendaVS.Negocio;
using TiendaVS.Negocio.Entidades;

namespace VentaVS.AccesoDatos
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appconfig.json")
                .Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("Default Connection"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClienteProducto>()
                .ToTable("ClientePorProducto")
                .HasKey(cp => new { cp.ProductoId, cp.ClienteId });
            modelBuilder.Entity<Cliente>()
                .HasKey(p => new { p.ClienteId });
        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<ClienteProducto> ClienteProductos { get; set; }
    }
}
