using Microsoft.EntityFrameworkCore;

namespace WebProject.Domain
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Project> Projects { get; set; }

        public DbSet<EnumExecutorType> EnumExecutorTypes { get; set; }

        public DbSet<Executor> Executors { get; set; }
    }
}
