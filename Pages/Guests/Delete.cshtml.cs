using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Web2023Razor.Data;
using Web2023Razor.Models;

namespace Web2023Razor.Pages.Guests
{
    public class DeleteModel : PageModel
    {
        private readonly Web2023Razor.Data.Web2023RazorContext _context;

        public DeleteModel(Web2023Razor.Data.Web2023RazorContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Guest Guest { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Guest = await _context.Guest.FirstOrDefaultAsync(m => m.IdG == id);

            if (Guest == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Guest = await _context.Guest.FindAsync(id);

            if (Guest != null)
            {
                _context.Guest.Remove(Guest);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
