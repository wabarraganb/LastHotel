using Microsoft.EntityFrameworkCore;

namespace Alten.LastHotel.Persistence
{
    public class LastHotelContext : DbContext
    {
        public LastHotelContext(DbContextOptions<LastHotelContext> options) : base(options) { }
 
        public DbSet<Domain.Customer> Customers { get; set; }
        public DbSet<Domain.Room> Rooms { get; set; }
    }
}
