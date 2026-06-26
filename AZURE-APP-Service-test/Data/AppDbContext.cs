using Microsoft.EntityFrameworkCore;

namespace AZURE_APP_Service_test.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<Person> Persons { get; set; }
    }
}
