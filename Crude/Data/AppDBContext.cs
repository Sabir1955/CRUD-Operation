using Microsoft.EntityFrameworkCore;
using CRUDE.Models;

namespace CRUDE.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}