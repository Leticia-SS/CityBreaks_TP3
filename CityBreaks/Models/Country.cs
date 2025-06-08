using System.ComponentModel.DataAnnotations.Schema;

namespace CityBreaks.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string CountryCode { get; set; }

        [Column("CountryName")]

        public string CountryName { get; set; }
        public List<City> Cities { get; set; } = new List<City>();

    }
}
