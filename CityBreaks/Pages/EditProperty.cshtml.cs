using CityBreaks.Data;
using CityBreaks.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CityBreaks.Pages
{
    public class EditPropertyModel : PageModel
    {
        private readonly CityBreaksContext _context;

        public EditPropertyModel(CityBreaksContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Property Property { get; set; } = new();

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Property = await _context.Properties.FindAsync(id);

            if (Property == null)
            {
                return NotFound();
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            Console.WriteLine("OnAsync postado");

            var property = await _context.Properties.FindAsync(id);

            if (property == null)
            {
                return NotFound();
            }

            var updated = await TryUpdateModelAsync(
                property,
                "Property",
                p => p.Name,
                p => p.PricePerNight
            );


            await _context.SaveChangesAsync();
            return RedirectToPage("/Index");
        }

    }
}
