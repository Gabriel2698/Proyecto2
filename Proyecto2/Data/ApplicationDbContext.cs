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





    }
}
