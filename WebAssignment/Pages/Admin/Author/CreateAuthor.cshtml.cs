using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAssignment.Pages.Admin.Author
{
    public class CreateAuthorModel : PageModel
    {
        [FromForm]
        public Models.Author Author { get; set; }

        public void OnPost()
        {
        }

        public void OnGet()
        {
        }
    }
}
