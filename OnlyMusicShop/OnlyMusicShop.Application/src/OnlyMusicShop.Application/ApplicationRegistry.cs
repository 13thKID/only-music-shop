using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OnlyMusicShop.Application.Repositories;

namespace OnlyMusicShop.Application
{
	public static class ApplicationRegistry
	{
		public static void AddApplication(this IServiceCollection services)
		{
			services.AddScoped<IGuitarRepository, GuitarRepository>();
			services.AddDbContext<OnlyMusicDbContext>(options => options.UseSqlServer(
                "Server=(localdb)\\mssqllocaldb;Database=OnlyMusicShopDB;Trusted_Connection=True;TrustServerCertificate=true"
            ));
		}
	}
}
