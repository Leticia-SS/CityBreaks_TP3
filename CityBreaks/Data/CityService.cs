﻿using CityBreaks.Models;
using Microsoft.EntityFrameworkCore;

namespace CityBreaks.Data
{
    public class CityService : ICityService
    {
        private readonly CityBreaksContext _context;
        public CityService(CityBreaksContext context) 
        {
            _context = context;
        }

        public async Task<List<City>> GetAllAsync()
        {

            return await _context.Cities
                .Include(c => c.Country)
                .Include(c => c.Properties)
                .ToListAsync();
        }

        public async Task<City?> GetByNameAsync(string name)
        {
            return await _context.Cities
                .Include(c => c.Properties)
                .Where(c => EF.Functions.Collate(c.Name, "NOCASE") == name)
                .FirstOrDefaultAsync();
        }

    }
}
