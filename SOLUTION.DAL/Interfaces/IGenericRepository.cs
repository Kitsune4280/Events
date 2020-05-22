using System;
using System.Collections.Generic;
using System.Text;

namespace SOLUTION.DAL.Interfaces
{
    public interface IGenericRepository<TEntity, TId> where TEntity: IEntity<TId>
    {
        int Create(TEntity entity);
        TEntity Get(TId id);
        void Update(TEntity entity);
        void Delete(TId id);
        IEnumerable<TEntity> GetAll();
    }
}
