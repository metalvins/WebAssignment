using System;
using Microsoft.EntityFrameworkCore;

namespace WebAssignment.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Blog> Blogs { get; set; }

        public DbSet<Models.Author> Authors { get; set; }
    }
}
