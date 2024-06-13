using Microsoft.EntityFrameworkCore;
using Sample_CQRS_API.Models;

namespace Sample_CQRS_API.Database
{
    public class DataDbContext : DbContext
    {
        public DataDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Customer> Customers { get; set; }
    }
}
