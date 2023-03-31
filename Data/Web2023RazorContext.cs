using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Web2023Razor.Models;

namespace Web2023Razor.Data
{
    public class Web2023RazorContext : DbContext
    {
        public Web2023RazorContext (DbContextOptions<Web2023RazorContext> options)
            : base(options)
        {
        }

        public DbSet<Web2023Razor.Models.Guest> Guest { get; set; }
    }
}
