using CityBreaks.Data;
using CityBreaks.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace CityBreaks.Pages
{
    public class CreatePropertyModel : PageModel
    {
        private readonly CityBreaksContext _context;

        public CreatePropertyModel(CityBreaksContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Property Property { get; set; } = new();

        public List<SelectListItem> Cities { get; set; } = new();

        public async Task OnGetAsync()
        {
            Cities = await _context.Cities
                .Select(c => new SelectListItem
                {
                    Value = c.Id.ToString(),
                    Text = c.Name
                })
                .ToListAsync();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            Console.WriteLine("OnPostAdsync clicado");

            var property = new Property
            {
                Name = Property.Name,
                PricePerNight = Property.PricePerNight,
                CityId = Property.CityId
            };

            await _context.Properties.AddAsync(property);
            await _context.SaveChangesAsync();

            return RedirectToPage("Index");
        }
    }
}
