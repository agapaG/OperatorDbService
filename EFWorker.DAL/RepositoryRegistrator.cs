using EFWorker.Interface;
using Microsoft.Extensions.DependencyInjection;
using EFWorker.DAL.Entities.No;
using EFWorker.DAL.Entities.Alarm;

namespace EFWorker.DAL
{
	public static class RepositoryRegistrator
	{
		public static IServiceCollection RegisterDbRepository(this IServiceCollection services) => services
			.AddTransient<IDbRepository<N03>, DbRepositoryNo<N03>>()
			.AddTransient<IDbRepository<N04>, DbRepositoryNo<N04>>()
			.AddTransient< IDbRepository<OperatorSett>, DbRepositoryAlarm<OperatorSett>>()
		;
	}
}
