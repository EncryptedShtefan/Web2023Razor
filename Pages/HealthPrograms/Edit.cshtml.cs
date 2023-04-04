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

namespace Web2023Razor.Pages.HealthPrograms
{
    public class EditModel : PageModel
    {
        private readonly Web2023Razor.Data.Web2023RazorContext _context;

        public EditModel(Web2023Razor.Data.Web2023RazorContext context)
        {
            _context = context;
        }

        [BindProperty]
        public HealthProgram HealthProgram { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            HealthProgram = await _context.HealthPrograms.FirstOrDefaultAsync(m => m.IdP == id);

            if (HealthProgram == null)
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

            _context.Attach(HealthProgram).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HealthProgramExists(HealthProgram.IdP))
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

        private bool HealthProgramExists(int id)
        {
            return _context.HealthPrograms.Any(e => e.IdP == id);
        }
    }
}
