using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ACCESS_Razor.Data;
using RazorPagesMovie.Models;

namespace ACCESS_Razor.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly ACCESS_Razor.Data.ACCESS_RazorContext _context;

        public IndexModel(ACCESS_Razor.Data.ACCESS_RazorContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
