using System;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using EFWorker.DAL;
using EFWorker.DAL.Context;

namespace OperatorDbService.Data
{
	internal static class RegistratorDbAlarm
	{
		public static IServiceCollection RegisterDbAlarm(this IServiceCollection services,
			IConfiguration Configuration) => services
			.AddDbContext<EFWorkerContextAlarm>(opt =>
			{
				var type = Configuration["Type"];
				switch (type) 
				{
					case null: throw new InvalidOperationException("Не определен тип БД");
					default: throw new InvalidOperationException($"Тип подключения {type} не поддерживается");

					case "alarm":
						opt.UseSqlServer(Configuration.GetConnectionString(type));
						break;
				}
			})
			.RegisterDbRepository()
		;
	}
}
