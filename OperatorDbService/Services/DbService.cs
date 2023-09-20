using System.Linq;

using EFWorker.DAL.Entities.No;
using EFWorker.Interface;

namespace OperatorDbService.Services
{
	internal class DbService
	{
		private readonly IDbRepository<N03> N03S;
		private readonly IDbRepository<N04> N04S;

		public DbService(IDbRepository<N03> n03,IDbRepository<N04> n04) 
		{
			N03S = n03;
			N04S = n04;

			//Данные считываются нормально
			var values0 = N04S.Items.Take(3).ToArray();

			//Данные не считываются - выдает исключение "Data is Null"
			var values1 = N03S.Items.Take(3).ToArray();

		}
	}
}
