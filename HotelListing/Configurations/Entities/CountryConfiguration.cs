﻿using HotelListing.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.Configurations.Entities
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasData(

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
        }
    }
}
