using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ViewData.Models;

namespace ViewData.Data
{
    public class ViewDataContext : DbContext
    {
        public ViewDataContext (DbContextOptions<ViewDataContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Product { get; set; }

        public DbSet<Category> Category { get; set; }
    }
}
