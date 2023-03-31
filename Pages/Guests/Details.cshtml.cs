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
    public class DetailsModel : PageModel
    {
        private readonly Web2023Razor.Data.Web2023RazorContext _context;

        public DetailsModel(Web2023Razor.Data.Web2023RazorContext context)
        {
            _context = context;
        }

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
    }
}
