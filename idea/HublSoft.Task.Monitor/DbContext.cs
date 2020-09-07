using Microsoft.EntityFrameworkCore;

namespace Hublsoft.Monitor
{
    public class HublSoftDbContext : DbContext
    {
        public HublSoftDbContext(DbContextOptions<HublSoftDbContext> options) : base(options)
        {
        }

        public DbSet<LoginMonitorModel> UserLogins { get; set; }
    }
}

