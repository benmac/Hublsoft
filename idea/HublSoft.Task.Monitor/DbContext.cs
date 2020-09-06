using Microsoft.EntityFrameworkCore;

namespace Hublsoft.Task.Monitor
{
    public class HublSoftDbContext : DbContext
    {
        public HublSoftDbContext(DbContextOptions<HublSoftDbContext> options) : base(options)
        {
        }

        public DbSet<LoginMonitorModel> UserLogins { get; set; }
    }
}

