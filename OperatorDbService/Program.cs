using System;
using System.Windows;

using Microsoft.Extensions.Hosting;


namespace OperatorDbService
{
	internal class Program
	{
		[System.STAThreadAttribute()]
		internal static void Main(string[] args) 
		{
			try
			{
				OperatorDbService.App app = new OperatorDbService.App();	
				app.InitializeComponent();
				app.Run();
			}
			catch(Exception ex) 
			{
				MessageBox.Show(ex.Message);
			}
		}

		public static IHostBuilder CreateHostBuilder(string[] Args) => Host
			.CreateDefaultBuilder(Args)
			.ConfigureServices(App.ConfigureServices)
		;

	}
}
