using CityBreaks.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CityBreaks.Data.Configuration
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public CountryConfiguration() { }
    
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.Property(c => c.CountryName)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("CountryName");
            builder.HasData(
                new Country { Id = 1, CountryCode = "BRA", CountryName = "Brasil" },
                new Country { Id = 2, CountryCode = "FRA", CountryName = "Franca" },
                new Country { Id = 3, CountryCode = "ALE", CountryName = "Alemanha" },
                new Country { Id = 4, CountryCode = "RUS", CountryName = "Russia" },
                new Country { Id = 5, CountryCode = "CHI", CountryName = "China" }
            );
        }
    }
}
