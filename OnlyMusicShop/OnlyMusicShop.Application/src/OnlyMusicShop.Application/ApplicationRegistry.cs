using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OnlyMusicShop.Application.Repositories;

namespace OnlyMusicShop.Application
{
	public static class ApplicationRegistry
	{
		public static void AddApplication(this IServiceCollection services, IConfiguration Configuration)
		{
			services.AddScoped<IGuitarRepository, GuitarRepository>();
			services.AddDbContext<OnlyMusicDbContext>(options => options.UseSqlServer(
				Configuration.GetConnectionString("DefaultConnection")
			));
		}
	}
}
