using Microsoft.EntityFrameworkCore;

namespace CountryWebApi.Model
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {
        }
        public DbSet<CountryItem> CountryItems { get; set; } = null!;
    }
}
