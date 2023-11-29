using Microsoft.EntityFrameworkCore;
using OnlyMusicShop.Domain.Entities;

namespace OnlyMusicShop.Application.Repositories
{
	internal class OnlyMusicDbContext : DbContext
	{
        public DbSet<Guitar> Guitars { get; set; }

        public OnlyMusicDbContext(DbContextOptions<OnlyMusicDbContext> options) : base(options)
        { 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Guitar>()
                .Property(b => b.Price)
                .HasPrecision(9, 2)
                .IsRequired();
        }
    }
}