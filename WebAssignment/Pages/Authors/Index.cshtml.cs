using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebAssignment.Context;
using WebAssignment.Models;

namespace WebAssignment.Pages.Authors
{
    public class IndexModel : PageModel
    {
        private readonly WebAssignment.Context.DataContext _context;

        public IndexModel(WebAssignment.Context.DataContext context)
        {
            _context = context;
        }

        public IList<Author> Author { get;set; }

        public async Task OnGetAsync()
        {
            Author = await _context.Authors.ToListAsync();
        }
    }
}
