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
    public class IndexModel : PageModel
    {
        private readonly Web2023Razor.Data.Web2023RazorContext _context;

        public IndexModel(Web2023Razor.Data.Web2023RazorContext context)
        {
            _context = context;
        }

        public IList<HealthProgram> HealthProgram { get;set; }

        public async Task OnGetAsync()
        {
            HealthProgram = await _context.HealthPrograms.ToListAsync();
        }
    }
}
