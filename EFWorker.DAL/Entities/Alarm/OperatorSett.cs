
using EFWorker.DAL.Entities.Base;

namespace EFWorker.DAL.Entities.Alarm
{
	/// <summary>
	/// Контекст таблицы 'Operators' из БД 'alarm'
	/// Поля:
	/// Id [PK, int, not null]
	/// Surname [string/char(25), null]
	/// Name [string/char(25), null]
	/// Password [string/char(25), null]
	/// Online [byte/tinyint, null]
	/// </summary>
	public class OperatorSett : NamedEntity
	{
		public string? Surname { get; set; }
		public string? Password { get; set; }
		public byte Online { get; set; }
	}

}
