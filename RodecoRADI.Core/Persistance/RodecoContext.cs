using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using RodecoRADI.Core.Persistance.Models;

namespace RodecoRADI.Core.Persistance
{
    public class RodecoContext : DbContext
    {
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<Tunnel> Tunnels { get; set; }
        public DbSet<Photo> Photos { get; set; }

        public RodecoContext(DbContextOptions<RodecoContext> options) : base(options) { }
    }

    public class RodecoContextFactory : IDesignTimeDbContextFactory<RodecoContext>
    {
        public RodecoContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<RodecoContext>();
            optionsBuilder.UseSqlServer("Data Source=MAXIDATA-VM\\MAXIDATA;Initial Catalog=rodeco;User ID=sa;Password=MD#sql");

            return new RodecoContext(optionsBuilder.Options);
        }
    }
}
