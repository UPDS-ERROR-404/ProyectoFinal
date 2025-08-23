using Microsoft.EntityFrameworkCore;

namespace Error404_Parkiando.Data
{
    public class ParkingDbContext : DbContext
    {
        public ParkingDbContext(DbContextOptions<ParkingDbContext> options) : base(options) { }

        public DbSet<Ticket> Tickets => Set<Ticket>();
        public DbSet<ParkingSpot> ParkingSpots => Set<ParkingSpot>();

        protected override void OnModelCreating(ModelBuilder m)
        {
            m.Entity<ParkingSpot>()
             .HasIndex(x => x.Code).IsUnique();

            m.Entity<Ticket>()
             .Property(x => x.Amount)
             .HasPrecision(18, 2);
        }
    }
}