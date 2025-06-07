using CityBreaks.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CityBreaks.Data.Configuration
{
    public class PropertyConfiguration : IEntityTypeConfiguration<Property>
    {
        public PropertyConfiguration() { }

        public void Configure(EntityTypeBuilder<Property> builder) 
        {
            builder.Property(p => p.Name)
                .HasMaxLength(100)
                .HasColumnName("PropertyName");
            builder.HasData(
                new Property { Id = 1, Name = "Copacabana Palace", PricePerNight = 500, CityId = 1 },
                new Property { Id = 2, Name = "Ipanema Casa de Praia", PricePerNight = 350, CityId = 1 },
                new Property { Id = 3, Name = "Torre Eiffel", PricePerNight = 450, CityId = 2 },
                new Property { Id = 4, Name = "Apartamento Louvre", PricePerNight = 400, CityId = 2 },
                new Property { Id = 5, Name = "Brandenburg Suite", PricePerNight = 380, CityId = 3 },
                new Property { Id = 6, Name = "Red Square Hotel", PricePerNight = 300, CityId = 4 },
                new Property { Id = 7, Name = "Great Wall Resort", PricePerNight = 420, CityId = 5 }
            );

        }

    }
}
