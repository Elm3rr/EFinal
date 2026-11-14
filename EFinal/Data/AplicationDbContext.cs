using Microsoft.EntityFrameworkCore;
using EFinal.Modelos;

namespace EFinal.Data
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Vehiculo> Vehiculos { get; set; }
    }
}
