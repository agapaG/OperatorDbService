
using OperatorDbService.ViewModels.Base;

namespace OperatorDbService.ViewModels
{
	internal class MainWindowViewModel : BaseViewModel
	{
		#region Свойства

		#region AddViewModels
		public DbServiceViewModel DbServiceView { get; }
		#endregion

		#region Titel
		private string _Title = string.Empty;
		public string Title { get => _Title; set => Set(ref _Title, value); }
		
		#endregion

		#endregion

		public MainWindowViewModel(DbServiceViewModel dbServiceView)
		{
			Title = "Главное окно";
			DbServiceView = dbServiceView;
		}
	}
}
