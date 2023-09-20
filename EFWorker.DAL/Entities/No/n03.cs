
using EFWorker.DAL.Entities.Base;

namespace EFWorker.DAL.Entities.No
{
	/// <summary>
	/// Контекст таблицы 'n03' из БД 'no'
	/// Поля:
	/// id [int, PK, not null]
	/// fn [string/varchar(100), null]
	/// adr [string/varchar(255), null]
	/// adrno [string/varchar(255), null]
	/// rayon [short/smallint, null]
	/// dve [DateTime/datetime, null]
	/// kd [short/smallint, null]
	/// otv [string/varchar(200), null]
	/// ot [string/varchar(200), null]
	/// ps [string/varchar(200), null]
	/// inz [byte/tinyint, null]
	/// inp [short/smallint, null]
	/// nz [int/int, null]
	/// nb [string/varchar(27), null]
	/// status [string/varchar(27), null]
	/// mcs [bool/bit, null]
	/// dm [DateTime/datetime, null]
	/// nbr [string/varchar(27), null]
	/// ds [DateTime/datetime, null]
	/// ira [byte/tinyint, null]
	/// kto [byte/tinyint, null]
	/// dakto [DateTime/datetime, null]
	/// netob [byte/tinyint, null]
	/// </summary>
	public class N03 : Entity
	{
		public string? Fn { get; set; }
		public string? Adr { get; set; }
		public string? Adrno { get; set; }
		public short Rayon { get; set; }
		public DateTime? Dve { get; set; }
		public short? Kd { get; set; }
		public string? Otv { get; set; }
		public string? Ot { get; set; }
		public string? Ps { get; set; }
		public byte Inz { get; set; }
		public short Inp { get; set; }
		public int Nz { get; set; }
		public string? Nb { get; set; }
		public string? Status { get; set; }
		public bool Mcs { get; set; }
		public DateTime? Dm { get; set; }
		public string? Nbr { get; set; }
		public DateTime? Ds { get; set; }
		public byte? Ira { get; set; }
		public byte? Kto { get; set; }
		public DateTime? Dakto { get; set; }
		public bool? Netob { get; set; }
	}

}
