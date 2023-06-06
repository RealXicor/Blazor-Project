using Microsoft.EntityFrameworkCore;
using Project.Models;

namespace Project.Data
{
    public class InquiriesDbContext : DbContext
    {
        public InquiriesDbContext(DbContextOptions<InquiriesDbContext> options) : base(options)
        {

        }
        public DbSet<Inquiries> Inquiries { get; set; }
    }
}
