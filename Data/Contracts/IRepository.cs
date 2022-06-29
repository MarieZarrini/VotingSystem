using Entities;

namespace Data.Contracts
{
	public interface IRepository<TEntity> where TEntity : class, IEntity
	{
		void Add(TEntity entity);
		TEntity GetById(int id);
		List<TEntity> GetAll();
		void Delete(TEntity entity);
	}
}