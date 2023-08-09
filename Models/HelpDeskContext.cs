using Microsoft.EntityFrameworkCore;

namespace IT_HELPDESKTICKET.Models
{
    public class HelpDeskContext:DbContext
    {
        public HelpDeskContext()
        {
        }

        public HelpDeskContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("A FALLBACK CONNECTION STRING");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
