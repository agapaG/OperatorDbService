
using EFWorker.DAL.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFWorker.DAL.Entities.No
{
	/// <summary>
	/// Контекст таблицы 'n04' из БД 'no'
	/// Поля:
	/// id [int, PK, not null]
	/// num [string/varchar(37), null]
	/// dz [DateTime/datetime, null]
	/// dd [DateTime/datetime, null]
	/// numi [byte/tinyint, null]
	/// numz [int/int, null]
	/// Smo [decimal/money, null]
	/// status [string/varchar(20), null]
	/// smote [decimal/money, null]
	/// dw [DateTime/datetime, null]
	/// ds [DateTime/datetime, null]
	/// numbyx [string/varchar(27), null]
	/// cgl [DateTime/datetime, null]
	/// inza [short/smallint, not null]
	/// kbck [byte/tinyint, null]
	/// pdp [string/varchar(100), null]
	/// dkgd [decimal/money, not null]
	/// sms [string/varchar(33), null]
	/// idrb [byte/tinyint, null]
	/// num1c [string/varchar(27), null]
	/// egodt [DateTime/datetime, null]
	/// nmug [string/varchar(20), null]
	/// </summary>
	public class N04 : Entity
	{
		public string? Num { get; set; }
		public DateTime? Dz { get; set; }
		public DateTime? Dd { get; set; }
		public byte? Numi { get; set; }
		public int? Numz { get; set; }
		[Column(TypeName = "desimal(18.2)")]
		public decimal? Smo { get; set; }
		public string? Status { get; set; }
		[Column(TypeName = "desimal(18.2)")]
		public decimal? Smote { get; set; }
		public DateTime? Dw { get; set; }
		public DateTime? Ds { get; set; }
		public string? Numbyx { get; set; }
		public DateTime? Cgl { get; set; }
		public short Inza { get; set; }
		public byte? Kbck { get; set; }
		public string? Pdp { get; set; }
		[Column(TypeName = "desimal(18.2)")]
		public decimal Dkgd { get; set; }
		public string? Sms { get; set; }
		public byte? Idrb { get; set; }
		public string? Num1c { get; set; }
		public DateTime? Egodt { get; set; }
		public string? Nmug { get; set; }
	}

}
