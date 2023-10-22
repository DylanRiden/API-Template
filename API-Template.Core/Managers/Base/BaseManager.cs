using API_Template.Core.DataModels.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Template.Core.Managers.Base
{
    internal abstract class BaseManager<TEntity> : IManager<TEntity> 
        where TEntity: BaseModel
    {
        protected readonly AppDataContext dataContext;
        protected readonly DbSet<TEntity> dataSet;

        public BaseManager(AppDataContext dataContext)
        {
            this.dataContext = dataContext;
            this.dataSet = GetDbSet();
        }

        protected abstract DbSet<TEntity> GetDbSet();

        public virtual async Task<TEntity?> GetAsync(Guid id)
        {
            return await this.GetDbSet().FirstOrDefaultAsync(e => e.Id == id);
        }

        public virtual IQueryable<TEntity> GetList(Func<IQueryable<TEntity>, IQueryable<TEntity>> query)
        {
            return query(this.GetDbSet());
        }

        public virtual async Task AddAsync(TEntity entity)
        {
            await this.GetDbSet().AddAsync(entity);
            await this.dataContext.SaveChangesAsync();
        }

        public virtual async Task AddRangeAsync(IQueryable<TEntity> entities)
        {
            await this.GetDbSet().AddRangeAsync(entities);
            await this.dataContext.SaveChangesAsync();
        }

        public virtual async Task UpdateAsync(TEntity entity)
        {
            this.GetDbSet().Update(entity);
            await this.dataContext.SaveChangesAsync();
        }

        public virtual async Task UpdateRangeAsync(IQueryable<TEntity> entities)
        {
            this.GetDbSet().UpdateRange(entities);
            await this.dataContext.SaveChangesAsync();
        }

        public virtual async Task DeleteAsync(Guid id)
        {
            TEntity? entity = await this.GetAsync(id);
            if (entity is null)
            {
                throw new Exception("Entity does not exist");
            }
            else
            {
                this.GetDbSet().Remove(entity);
                await this.dataContext.SaveChangesAsync();
            }
        }

        public virtual async Task DeleteAsync(TEntity entity) =>
            await this.DeleteAsync(entity.Id);

        public virtual async Task DeleteRangeAsync(IQueryable<TEntity> entities)
        {
            this.GetDbSet().RemoveRange(entities);
            await this.dataContext.SaveChangesAsync();
        }

    }
}
