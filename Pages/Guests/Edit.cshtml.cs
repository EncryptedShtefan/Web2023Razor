using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Web2023Razor.Data;
using Web2023Razor.Models;

namespace Web2023Razor.Pages.Guests
{
    public class EditModel : PageModel
    {
        private readonly Web2023Razor.Data.Web2023RazorContext _context;

        public EditModel(Web2023Razor.Data.Web2023RazorContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Guest).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GuestExists(Guest.IdG))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool GuestExists(int id)
        {
            return _context.Guest.Any(e => e.IdG == id);
        }
    }
}
