using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;
using ACCESS_Razor.Models;

namespace ACCESS_Razor.Data
{
    public class ACCESS_RazorContext : DbContext
    {
        public ACCESS_RazorContext (DbContextOptions<ACCESS_RazorContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie.Models.Movie> Movie { get; set; } = default!;
        public DbSet<ACCESS_Razor.Models.Review> Review { get; set; } = default!;
    }
}
