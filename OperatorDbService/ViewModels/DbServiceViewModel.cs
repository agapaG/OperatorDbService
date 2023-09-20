
using OperatorDbService.Services;
using OperatorDbService.ViewModels.Base;

namespace OperatorDbService.ViewModels
{
	internal class DbServiceViewModel : BaseViewModel
	{
		private readonly DbService DbWorker;

		public DbServiceViewModel(DbService dbWorker) 
		{
			DbWorker = dbWorker;
		}
	}
}
