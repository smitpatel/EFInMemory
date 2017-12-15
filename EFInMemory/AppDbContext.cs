using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EFInMemory
{
    public class AppDbContext : DbContext
    {
        public static ILoggerFactory loggerFactory = new LoggerFactory().AddConsole(/*LogLevel.Trace*/);
        public AppDbContext()
        {
        }

        public DbSet<Agency> Agencies { get; set; }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Commission> Commissions { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseInMemoryDatabase("EFInMemory")/*.UseLoggerFactory(loggerFactory)*/;
        }
    }
}
