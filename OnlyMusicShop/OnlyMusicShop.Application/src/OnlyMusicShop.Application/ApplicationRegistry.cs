using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OnlyMusicShop.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyMusicShop.Application
{
	public static class ApplicationRegistry
	{
		public static void AddApplication(this IServiceCollection services)
		{
			services.AddScoped<IGuitarRepository, GuitarRepository>();
			services.AddDbContext<OnlyMusicDbContext>(options => options.UseSqlServer(
				"Server=localhost\\SQLEXPRESS;Database=only_music_shop;Trusted_Connection=True;TrustServerCertificate=true"
			));
		}
	}
}
