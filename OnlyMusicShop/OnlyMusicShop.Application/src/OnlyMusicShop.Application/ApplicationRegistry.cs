using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using FluentValidation;
using MediatR;
using OnlyMusicShop.Application.Behaviours;

namespace OnlyMusicShop.Application
{
	// Extension method - musisz stworzyć statyczną metodę w klasie statycznej
	public static class ApplicationRegistry
	{
		public static void AddApplication(this IServiceCollection services)
		{
			services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
			services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
			services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
		}
	}
}
