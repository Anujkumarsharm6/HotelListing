using HotelListing.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.Configurations.Entities
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(
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
