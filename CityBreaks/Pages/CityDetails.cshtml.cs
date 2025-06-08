using CityBreaks.Data;
using CityBreaks.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CityBreaks.Pages
{
    public class CityDetailsModel : PageModel
    {

        private readonly ICityService _service;

        public CityDetailsModel(ICityService service)
        {
            _service = service;
        }

        public City? City { get; set; }

        public async Task<IActionResult> OnGetAsync(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return NotFound();

            City = await _service.GetByNameAsync(name);
            if (City == null) return NotFound();

            return Page();
        }
    }
}
