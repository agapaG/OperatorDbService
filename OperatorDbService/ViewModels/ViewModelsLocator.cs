
using Microsoft.Extensions.DependencyInjection;

namespace OperatorDbService.ViewModels
{
	internal class ViewModelsLocator
	{
		public MainWindowViewModel MainViewModel =>
			App.Services.GetRequiredService<MainWindowViewModel>();	
	}
}
