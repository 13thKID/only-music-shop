using Microsoft.EntityFrameworkCore;
using OnlyMusicShop.Domain.Entities;

namespace OnlyMusicShop.Application.Repositories
{
	public class OnlyMusicDbContext : DbContext
	{
        public DbSet<Guitar> Guitars { get; set; }

        public OnlyMusicDbContext(DbContextOptions<OnlyMusicDbContext> options) : base(options)
        { 
        }

		//OnModelCreating() method is used to configure the model using ModelBuilder Fluent API
		protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Guitar>()
                .HasData(
                    new Guitar {
						Id = 1,
                        Name = "Gibson ES-335 Cherry",
						Manufacturer = "Gibson",
                        Model = "ES-335",
                        Type = "Semi-hollow",
                        Color = "Satin Cherry",
						Description = "Gitara elektryczna pół-hollow z przetwornikami skalibrowanymi typu T",
                        Price = 12999,
                    },
					new Guitar
					{
						Id = 2,
						Name = "Charvel Guthrie Govan HSH Flame Maple",
						Manufacturer = "Charvel",
						Model = "Guthrie Govan Signature",
						Type = "Strat",
						Color = "Flame Maple",
						Description = "Gitara elektryczna sygnowana przez Guthriego Govana",
						Price = 16690,
					},
					new Guitar
					{
						Id = 3,
						Name = "Jason Becker signature Kiesel",
						Manufacturer = "Kiesel",
						Model = "JB200C",
						Type = "Strat",
						Color = "Saphire blue",
						Description = "Gitara elektryczna sygnowana przez Guthriego Govana",
						Price = 15999,
					});
        }
    }
}