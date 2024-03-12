using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ACCESS_Razor.Data;
using ACCESS_Razor.Models;
using RazorPagesMovie.Models;

namespace ACCESS_Razor.Pages.Reviews
{
    public class IndexModel : PageModel
    {
        private readonly ACCESS_Razor.Data.ACCESS_RazorContext _context;

        public IndexModel(ACCESS_Razor.Data.ACCESS_RazorContext context)
        {
            _context = context;
        }
        public Movie Movie { get; set; } = default!;
        public IList<Review> Review { get;set; } = default!;

        public async Task OnGetAsync()
        {
           
            Review = await _context.Review
                .Include(r => r.Movie).ToListAsync();
        }
    }
}
