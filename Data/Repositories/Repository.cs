using Data.Contracts;
using Entities;

namespace Data.Repositories
{
	public class Repository<TEntity> : IRepository<TEntity>
		where TEntity : class, IEntity
	{
		private static readonly List<TEntity> Entities;
		static Repository()
		{
			Entities = new List<TEntity>();
		}


		public virtual void Add(TEntity entity)
		{
			entity.Id = GetTheLastId() + 1;
			Entities.Add(entity);
		}

		public virtual List<TEntity> GetAll()
		{
			return Entities.ToList();
		}


		public virtual TEntity GetById(int id)
		{
			return Entities.Find(e => e.Id == id);
		}

		public virtual void Delete(TEntity entity)
		{
			Entities.Remove(entity);
		}


		private int GetTheLastId()
		{
			return Entities.Count == 0 ? 0 : Entities.Last().Id;
		}
	}
}
