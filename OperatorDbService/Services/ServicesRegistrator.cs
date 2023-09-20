
using Microsoft.Extensions.DependencyInjection;

namespace OperatorDbService.Services
{
	internal static class ServicesRegistrator
	{
		public static IServiceCollection RegisterServics(this IServiceCollection services) => services
			.AddTransient<DbService>()
		;
	}
}
