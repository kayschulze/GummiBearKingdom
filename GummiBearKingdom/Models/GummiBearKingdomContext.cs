using Microsoft.EntityFrameworkCore;

namespace GummiBearKingdom.Models
{
    public class GummiBearKingdomContext : DbContext
    {
        public GummiBearKingdomContext()
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySql(@"Server=localhost;Port=8889;database=gummibearkingdomMigrations;uid=root;pwd=root;");
        }

        public GummiBearKingdomContext(DbContextOptions<GummiBearKingdomContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
