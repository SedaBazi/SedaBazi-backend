using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SedaBazi.Application.Interfaces.Contexts;
using SedaBazi.Domain.Entities.Audios;
using SedaBazi.Domain.Entities.Managements;
using SedaBazi.Domain.Entities.Users;

namespace SedaBazi.Persistence.Contexts
{
    public class DataBaseContext : IdentityDbContext<User>, IDataBaseContext
    {
        public DbSet<AudioCollection> AudioCollections { get; set; }

        public DbSet<Audio> Audios { get; set; }

        public DbSet<AudioLink> AudioLinks { get; set; }

        public DbSet<Management> Managements { get; set; }

        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<AudioCollection>().HasQueryFilter(p => !p.IsDeleted);
            modelBuilder.Entity<Audio>().HasQueryFilter(p => !p.IsDeleted);
            modelBuilder.Entity<Management>().HasQueryFilter(p => !p.IsDeleted);
            modelBuilder.Entity<AudioLink>().HasQueryFilter(p => !p.IsDeleted);
        }
    }
}
