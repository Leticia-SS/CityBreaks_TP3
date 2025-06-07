using CityBreaks.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CityBreaks.Data.Configuration
{
    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public CityConfiguration()
        {
        }

        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.Property(c => c.Name)
                .HasMaxLength(100)
                .IsRequired()
                .HasColumnName("CityName");
            builder.HasData(
                new City { Id = 1, Name = "Rio de Janeiro", CountryId = 1 },
                new City { Id = 2, Name = "Paris", CountryId = 2 },
                new City { Id = 3, Name = "Berlin", CountryId = 3 },
                new City { Id = 4, Name = "Moscow", CountryId = 4 },
                new City { Id = 5, Name = "Beijing", CountryId = 5 }
            );
        }

    }
}
