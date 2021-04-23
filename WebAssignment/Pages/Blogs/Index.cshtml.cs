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
    public class IndexModel : PageModel
    {
        private readonly WebAssignment.Context.DataContext _context;

        public IndexModel(WebAssignment.Context.DataContext context)
        {
            _context = context;
        }

        public IList<Blog> Blog { get;set; }

        public async Task OnGetAsync()
        {
            Blog = await _context.Blogs.ToListAsync();
        }
    }
}
