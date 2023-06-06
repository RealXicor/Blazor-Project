using Microsoft.EntityFrameworkCore;
using Project.Models;

namespace Project.Data
{
    public class ProductDbContext : DbContext

    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Product { get; set; }
    }
}
