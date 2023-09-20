
using Microsoft.Extensions.DependencyInjection;

namespace OperatorDbService.ViewModels
{
	internal static class ViewModelsRegistrator
	{
		public static IServiceCollection RegisterViewModels(this IServiceCollection services) => services
			.AddSingleton<MainWindowViewModel>()
			.AddSingleton<DbServiceViewModel>()
		;
	}
}
