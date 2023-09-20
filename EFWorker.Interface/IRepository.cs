﻿namespace EFWorker.Interface
{
	public interface IDbRepository<T> where T : class, IEntity, new()	
	{
		//Доступ ко всему, что хранится в репозитории
		IQueryable<T> Items { get; }

		//Получить элемент коллекции
		T GetValue(int id);
		Task<T> GetValueAsync(int id, CancellationToken Cansel = default);

		//Добавить сущьность в репозиторий
		T Add(T item);
		Task<T> AddAsync(T item, CancellationToken Cansel = default);

		//Изменение сущьности в репозитории
		void Update(T item);
		Task UpdateAsync(T item, CancellationToken Cansel = default);

		//Удаление сущьности из репозитория
		void Remove(int id);
		Task RemoveAsync(int id, CancellationToken Cansel = default);
	}
}
