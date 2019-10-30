using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MultasTransito.Models;

namespace MultasTransito.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Vehiculo> Vehiculo { get; set; }
        public DbSet<Multas> Multas { get; set; }
        public DbSet<Municipios> Municipios { get; set; }
        public DbSet<Propietario> Propietarios { get; set; }
    }
}
