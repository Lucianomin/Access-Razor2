using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ACCESS_Razor.Data;
using ACCESS_Razor.Models;

namespace ACCESS_Razor.Pages.Reviews
{
    public class CreateModel : PageModel
    {
        private readonly ACCESS_Razor.Data.ACCESS_RazorContext _context;

        public CreateModel(ACCESS_Razor.Data.ACCESS_RazorContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["MovieId"] = new SelectList(_context.Movie, "Id", "Genre");
            return Page();
        }

        [BindProperty]
        public Review Review { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Review.Add(Review);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
