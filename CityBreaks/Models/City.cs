﻿using System.ComponentModel.DataAnnotations.Schema;

namespace CityBreaks.Models
{
    public class City
    {
        public int Id { get; set; }
        
        [Column("CityName")]
        public string Name { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; } 
        public List<Property> Properties { get; set; } = new List<Property>();
    }
}
