using API_Template.Core.DataModels.Base;

namespace API_Template.Core.Managers.Base
{
    public interface IManager<TEntity> where TEntity : BaseModel
    {
        Task AddAsync(TEntity entity);
        Task AddRangeAsync(IQueryable<TEntity> entities);
        Task DeleteAsync(Guid id);
        Task DeleteAsync(TEntity entity);
        Task DeleteRangeAsync(IQueryable<TEntity> entities);
        Task<TEntity?> GetAsync(Guid id);
        IQueryable<TEntity> GetList(Func<IQueryable<TEntity>, IQueryable<TEntity>> query);
        Task UpdateAsync(TEntity entity);
        Task UpdateRangeAsync(IQueryable<TEntity> entities);
    }
}