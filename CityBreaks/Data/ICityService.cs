using CityBreaks.Models;

namespace CityBreaks.Data
{
    public interface ICityService
    {
        Task<List<City>> GetAllAsync() ;
    }
}
