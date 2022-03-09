using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskList.Core;

namespace TaskList.Data
{
    public partial class EntityRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        public virtual async Task<TEntity> GetByIdAsync(long? id)
        {

        }

        public virtual async Task<IList<TEntity>> GetByIdsAsync(IList<long> ids)
        { 
        
        }
        public virtual async Task<IList<TEntity>> GetAllAsync(Func<IQueryable<TEntity>, IQueryable<TEntity>> func = null)
        { 
        
        }

        public virtual async Task InsertAsync(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            await _dataProvider.InsertEntityAsync(entity);
        }

        public virtual async Task UpdateAsync(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            await _dataProvider.UpdateEntityAsync(entity);

        }

        public virtual async Task DeleteAsync(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));


            entity.Deleted = true;
            await _dataProvider.UpdateEntityAsync(entity);
        }
    }
}
