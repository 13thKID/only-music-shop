using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OnlyMusicShop.Infrastructue.Repositories;
using System.Reflection;

namespace OnlyMusicShop.Infrastructue
{
	// Extension method - musisz stworzyć statyczną metodę w klasie statycznej
	public static class InfrastructureRegistry
	{
		// Jako arg po this, wskazuje co będę rozszerzać; coś jak rozszerzanie JS w JavaScript
		public static void AddInfrastructure(this IServiceCollection services, string ConnectionString)
		{
			services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
			services.AddScoped<IGuitarRepository, GuitarRepository>();
			services.AddDbContext<OnlyMusicDbContext>(options => options.UseSqlServer(
				ConnectionString
			));
		}

		//// Roszerzam jakby obiekt / klasy String
		//public static string FormatString(this String value) {
		//	return value + 1;
		//}
	}
}
