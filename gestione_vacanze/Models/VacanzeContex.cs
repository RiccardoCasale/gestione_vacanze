using Microsoft.EntityFrameworkCore;

namespace gestione_vacanze.Models
{
    public class VacanzeContex : DbContext
    {
        public VacanzeContex(DbContextOptions<VacanzeContex> options) : base(options)
        {
        }

        public DbSet<Destinazione> Destinazioni { get; set; }
        public DbSet<Pacchetto> Pacchetti { get; set; }
        public DbSet<RecUtente> RecsUtente { get; set; }
        public DbSet<Despac> Despacs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Destinazione>().ToTable("Destinazione"); 
            modelBuilder.Entity<Pacchetto>().ToTable("Pacchetto");
            modelBuilder.Entity<RecUtente>().ToTable("RecUtente");
        }
    }
}
