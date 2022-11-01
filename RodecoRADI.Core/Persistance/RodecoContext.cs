using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using RodecoRADI.Core.Persistance.Models;

namespace RodecoRADI.Core.Persistance
{
    public class RodecoContext : DbContext
    {
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<Tunnel> Tunnels { get; set; }
        public DbSet<Bridge> Bridges { get; set; }
        public DbSet<Sidewalk> Sidewalks { get; set; }
        public DbSet<Wall> Walls { get; set; }
        public DbSet<Photo> Photos { get; set; }

        public RodecoContext(DbContextOptions<RodecoContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Gallery>().HasKey(x => x.Id);
            modelBuilder.Entity<Gallery>().Navigation(x => x.Photos).AutoInclude();
            
            modelBuilder.Entity<Tunnel>().HasKey(x => x.Id);
            modelBuilder.Entity<Tunnel>().Navigation(x => x.Photos).AutoInclude();
            
            modelBuilder.Entity<Bridge>().HasKey(x => x.Id);
            modelBuilder.Entity<Bridge>().Navigation(x => x.Photos).AutoInclude();
            
            modelBuilder.Entity<Sidewalk>().HasKey(x => x.Id);
            modelBuilder.Entity<Sidewalk>().Navigation(x => x.Photos).AutoInclude();
            
            modelBuilder.Entity<Wall>().HasKey(x => x.Id);
            modelBuilder.Entity<Wall>().Navigation(x => x.Photos).AutoInclude();
            
            base.OnModelCreating(modelBuilder);
        }
    }

    public class RodecoContextFactory : IDesignTimeDbContextFactory<RodecoContext>
    {
        public RodecoContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<RodecoContext>();
            optionsBuilder.UseSqlServer("Data Source=xxxxxxx;Initial Catalog=rodeco;User ID=sa;Password=xxxxxxx");

            return new RodecoContext(optionsBuilder.Options);
        }
    }
}
