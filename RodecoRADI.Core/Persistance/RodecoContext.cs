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
            modelBuilder.Entity<Tunnel>().HasKey(x => x.Id);
            modelBuilder.Entity<Bridge>().HasKey(x => x.Id);
            modelBuilder.Entity<Sidewalk>().HasKey(x => x.Id);
            modelBuilder.Entity<Wall>().HasKey(x => x.Id);

            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            var now = DateTime.UtcNow;
            foreach (var e in this.ChangeTracker.Entries().Where(x => x.Entity is IBaseEntity).Where(x => x.State == EntityState.Modified || x.State == EntityState.Added))
            {
                if (e.Entity is not IBaseEntity entity) break;
                if (entity.DateCreated == null) entity.DateCreated = now;
                entity.DateModified = now;
            }

            var list = this.ChangeTracker.Entries();
            foreach (var e in this.ChangeTracker.Entries().Where(x => x.Entity is Photo).Where(x => x.State == EntityState.Modified || x.State == EntityState.Added))
            {
                if (e.Entity is not Photo entity) break;
                if (entity.DateCreated == null) entity.DateCreated = now;
                entity.DateModified = now;
            }
            return base.SaveChanges();

        }
    }

    public class RodecoContextFactory : IDesignTimeDbContextFactory<RodecoContext>
    {
        public RodecoContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<RodecoContext>();
            optionsBuilder.UseSqlServer("CONNECTION STRING");

            return new RodecoContext(optionsBuilder.Options);
        }
    }
}
