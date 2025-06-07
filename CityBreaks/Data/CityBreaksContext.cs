using CityBreaks.Models;
using Microsoft.EntityFrameworkCore;

namespace CityBreaks.Data
{
    public class CityBreaksContext : DbContext
    {
        DbSet<Country> Countries { get; set; }
        public CityBreaksContext(DbContextOptions<CityBreaksContext> options) : base(options) { }
    }
}

