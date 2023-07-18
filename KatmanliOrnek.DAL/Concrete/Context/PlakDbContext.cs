using KatmanliOrnek.DAL.Concrete.Context.EntityConfiguration;
using KatmanliOrnek.Entities;
using Microsoft.EntityFrameworkCore;

namespace KatmanliOrnek.DAL.Concrete.Context
{
    public class PlakDbContext : DbContext
    {
        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<Plak> Plaks { get; set; }

        public virtual DbSet<Artist> Artists { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = @"Server=DESKTOP-89730OE\NESET; Database=PlakDb; Trusted_Connection=true;";

            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration())
                .ApplyConfiguration(new PlakConfiguration())
                .ApplyConfiguration(new ArtistConfiguration());
        }
    }
}
