using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Web2023Razor.Data;
using Web2023Razor.Models;

namespace Web2023Razor.Pages.HealthPrograms
{
    public class CreateModel : PageModel
    {
        private readonly Web2023Razor.Data.Web2023RazorContext _context;

        public CreateModel(Web2023Razor.Data.Web2023RazorContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public HealthProgram HealthProgram { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.HealthPrograms.Add(HealthProgram);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
