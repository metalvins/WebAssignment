using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebAssignment.Context;
using WebAssignment.Models;

namespace WebAssignment.Pages.Blogs
{
    public class DetailsModel : PageModel
    {
        private readonly WebAssignment.Context.DataContext _context;

        public DetailsModel(WebAssignment.Context.DataContext context)
        {
            _context = context;
        }

        public Blog Blog { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Blog = await _context.Blogs.FirstOrDefaultAsync(m => m.BlogID == id);

            if (Blog == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
