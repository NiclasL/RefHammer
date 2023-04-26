using Microsoft.EntityFrameworkCore;

namespace RefHammer.Model
{
    public class dbContext: DbContext
    {
        public dbContext(DbContextOptions<dbContext> options) : base(options)
        {
        }

        public DbSet<Game> GameItems { get; set; } = null!;
    }
}
