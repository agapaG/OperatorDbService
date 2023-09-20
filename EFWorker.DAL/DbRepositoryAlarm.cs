
using EFWorker.DAL.Context;
using EFWorker.DAL.Entities.Base;
using EFWorker.Interface;
using Microsoft.EntityFrameworkCore;

namespace EFWorker.DAL
{
	internal class DbRepositoryAlarm<T> : IDbRepository<T> where T : Entity, new()
	{
		private readonly EFWorkerContextAlarm _db;
		private readonly DbSet<T> _Set;

		public bool AutoSaveChanges { get; set; } = true;

		public DbRepositoryAlarm(EFWorkerContextAlarm db)
		{
			_db = db;
			_Set = db.Set<T>();
		}

		public virtual IQueryable<T> Items => _Set;

		public T GetValue(int id) => Items.SingleOrDefault(item => item.Id == id);

		public async Task<T> GetValueAsync(int id, CancellationToken Cancel = default) => await Items
			.SingleOrDefaultAsync(item => item.Id == id, Cancel)
			.ConfigureAwait(false);

		public T Add(T item)
		{
			if (item is null) throw new ArgumentNullException(nameof(item));
			_db.Entry(item).State = EntityState.Added;

			if (AutoSaveChanges)
				_db.SaveChanges();

			return item;
		}

		public async Task<T> AddAsync(T item, CancellationToken Cancel = default)
		{
			if (item is null) throw new ArgumentNullException(nameof(item));
			_db.Entry(item).State = EntityState.Added;

			if (AutoSaveChanges)
				await _db.SaveChangesAsync(Cancel).ConfigureAwait(false);

			return item;
		}


		public void Remove(int id)
		{
			_db.Remove(new T { Id = id });
			if (AutoSaveChanges)
				_db.SaveChanges();
		}

		public async Task RemoveAsync(int id, CancellationToken Cancel = default)
		{
			_db.Remove(new T { Id = id });

			if (AutoSaveChanges)
				await _db.SaveChangesAsync(Cancel).ConfigureAwait(false);
		}

		public void Update(T item)
		{
			if (item is null) throw new ArgumentNullException(nameof(item));
			_db.Entry(item).State = EntityState.Modified;

			if (AutoSaveChanges)
				_db.SaveChanges();
		}

		public async Task UpdateAsync(T item, CancellationToken Cancel = default)
		{
			if (item is null) throw new ArgumentNullException(nameof(item));
			_db.Entry(item).State = EntityState.Modified;

			if (AutoSaveChanges)
				await _db.SaveChangesAsync(Cancel).ConfigureAwait(false);
		}

	}
}
