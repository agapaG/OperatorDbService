using Microsoft.EntityFrameworkCore;
using EFWorker.DAL.Entities.No;


namespace EFWorker.DAL.Context
{
	public class EFWorkerContexNo : DbContext
	{
		public DbSet<N03> n03 { get; set; }
		public DbSet<N04> n04 { get; set; }
		public EFWorkerContexNo(DbContextOptions<EFWorkerContexNo> options) : base(options) { }	
	}
}
