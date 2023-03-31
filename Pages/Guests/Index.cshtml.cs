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
    public class IndexModel : PageModel
    {
        private readonly Web2023Razor.Data.Web2023RazorContext _context;

        public IndexModel(Web2023Razor.Data.Web2023RazorContext context)
        {
            _context = context;
        }

        public IList<Guest> Guest { get;set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList ApartmentNumbers { get; set; }

        [BindProperty(SupportsGet = true)]
        public string GuestApartmentNumber { get; set; }

        public async Task OnGetAsync()
        {
            IQueryable<string> apartmentsQuery = from m in _context.Guest
                                            orderby m.ApartmentNumber
                                                 select m.ApartmentNumber;

            var guests = from g in _context.Guest
                         select g;
            if (!string.IsNullOrEmpty(SearchString))
            {
                guests = guests.Where(s => s.Fio.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(GuestApartmentNumber))
            {
                guests = guests.Where(x => x.ApartmentNumber.Equals(GuestApartmentNumber));
            }


            ApartmentNumbers = new SelectList(await apartmentsQuery.Distinct().ToListAsync());
            Guest = await guests.ToListAsync();
        }
    }
}
