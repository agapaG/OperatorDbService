using Microsoft.EntityFrameworkCore;

using EFWorker.DAL.Entities.Alarm;

namespace EFWorker.DAL.Context
{
	public class EFWorkerContextAlarm : DbContext
	{
		public DbSet<OperatorSett> Operators { get; set; }
		public EFWorkerContextAlarm(DbContextOptions<EFWorkerContextAlarm> options) : base(options) { }
	}
}
