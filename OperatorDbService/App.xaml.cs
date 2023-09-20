using System;
using System.Windows;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OperatorDbService.ViewModels;
using OperatorDbService.Services;
using OperatorDbService.Data;

namespace OperatorDbService
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		private static IHost __Host;
		public static IHost Host => __Host
			?? Program.CreateHostBuilder(Environment.GetCommandLineArgs()).Build();
		public static IServiceProvider Services => Host.Services;

		internal static void ConfigureServices(HostBuilderContext host, IServiceCollection services) => services
			.RegisterViewModels()
			.RegisterServics()
			.RegisterDbAlarm(host.Configuration.GetSection("DbAlarm"))
		    .RegisterDbNo(host.Configuration.GetSection("DbNo"))
		;
		
		
		protected override async void OnStartup(StartupEventArgs e)
		{
			var host = Host;
			base.OnStartup(e);
			await host.StartAsync().ConfigureAwait(false);
		}

		protected override async void OnExit(ExitEventArgs e)
		{
			var host = Host;
			base.OnExit(e);
			await host.StopAsync().ConfigureAwait(false);
			Host.Dispose();	
		}
	}
}
