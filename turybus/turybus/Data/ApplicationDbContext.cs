using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using turybus.Models;

namespace turybus.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
        public DbSet<Ruta> Rutas { get; set; }
        public DbSet<Boleto> Boletos { get; set; }
        public DbSet<Vehiculo> Vehiculos { get; set; }
        public DbSet<Conductor> Conductors { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Revision> Revisions { get; set; }
    }
}
