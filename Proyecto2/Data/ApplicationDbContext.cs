using Microsoft.EntityFrameworkCore;
using Proyecto2.Models;



namespace Proyecto2.Server.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }


        public DbSet<Admin> Adminis { get; set; }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Entrenador> Entrenadores { get; set; }

        public DbSet<Inventario> Inventarios { get; set; }

        public DbSet<Factura> Facturas { get; set; }


        public DbSet<Metrica> Metricas { get; set; }

        public DbSet<Horario> Horarios { get; set; }

        public DbSet<Matricula> Matriculas { get; set; }

        public DbSet<Reporte> Reportes { get; set; }
    }
}
