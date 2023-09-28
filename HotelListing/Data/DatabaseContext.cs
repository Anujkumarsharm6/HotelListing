using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace HotelListing.Data
{
    public class DatabaseContext: DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Country> countries { get; set; }
        public DbSet<Hotel> hotels { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "India",
                    State = "Andhra Pradesh"
                },
                new Country
                {
                    Id = 2,
                    Name = "United States of America",
                    State = "Nebrasaka"
                },
                new Country
                {
                    Id = 3,
                    Name = "Canada",
                    State = "British Columbia"
                }


                );
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Raddision",
                    Address = "Hyderabad",
                    Rating = 3,
                    CountryId = 1,

                },
                new Hotel
                {
                    Id = 2,
                    Name = "Holiday Inn",
                    Address = "Nebrasaka City",
                    Rating = 3.5,
                    CountryId = 2,
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Sandman Hotels and suite",
                    Address = "Squamish, BC",
                    Rating = 4,
                    CountryId = 3,
                }


                );
        }
    }
}
