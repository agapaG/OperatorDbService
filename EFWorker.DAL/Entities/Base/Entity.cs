using EFWorker.Interface;

namespace EFWorker.DAL.Entities.Base
{
	public abstract class Entity : IEntity
	{
		public int Id { get; set; }	
	}
}
