using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebAssignment.Pages.Admin.Blog
{
    public class CreateBlogModel : PageModel
    {
        [FromForm]
        public Models.Blog Blog { get; set; }

        private List<Models.Author> Authors { get; set; } = new List<Models.Author>();

        public IEnumerable<SelectListItem> AuthorList { get; private set; }

        public CreateBlogModel()
        {
            Models.Author A1 = new Models.Author()
            {
                Fname = "Enid",
                Lname = "Blyton",
                Email = "enid.blyton@readersclub.com"
            };
            Models.Author A2 = new Models.Author()
            {
                Fname = "Roald",
                Lname = "Dahl",
                Email = "roald.dahl@readersclub.com"
            };
            Models.Author A3 = new Models.Author()
            {
                Fname = "Robert",
                Lname = "Stine",
                Email = "robert.stine@readersclub.com"
            };
            Models.Author A4 = new Models.Author()
            {
                Fname = "Charles",
                Lname = "Dickens",
                Email = "charles.dickens@readersclub.com"
            };
            Models.Author A5 = new Models.Author()
            {
                Fname = "Ruskin",
                Lname = "Bond",
                Email = "ruskin.bond@readersclub.com"
            };

            Authors.Add(A1);
            Authors.Add(A2);
            Authors.Add(A3);
            Authors.Add(A4);
            Authors.Add(A5);
        }

        public void OnPost()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            foreach (var author in Authors)
            {
                SelectListItem item = new SelectListItem(author.Fname + " " + author.Lname, author.Email);
                list.Add(item);
                if (author.Email.Equals(Request.Form.ToList()[3].Value))
                {
                    Blog.Author = author;
                    item.Selected = true;
                }
            }
            AuthorList = list;
        }

        public void OnGet()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            foreach (var author in Authors)
            {
                list.Add(new SelectListItem(author.ToString(), author.Email));
            }
            AuthorList = list;
        }
    }
}
