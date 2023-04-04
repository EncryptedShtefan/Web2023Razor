using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Web2023Razor.Data;
using Web2023Razor.Models;

namespace Web2023Razor.Pages.HealthPrograms
{
    public class DeleteModel : PageModel
    {
        private readonly Web2023Razor.Data.Web2023RazorContext _context;

        public DeleteModel(Web2023Razor.Data.Web2023RazorContext context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            HealthProgram = await _context.HealthPrograms.FindAsync(id);

            if (HealthProgram != null)
            {
                _context.HealthPrograms.Remove(HealthProgram);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
