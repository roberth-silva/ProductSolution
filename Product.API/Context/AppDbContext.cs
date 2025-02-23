using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Product.API.Models;

namespace Product.API.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<MyProduct> Products { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
