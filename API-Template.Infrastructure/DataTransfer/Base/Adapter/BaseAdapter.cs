using API_Template.Core.DataModels.Base;
using API_Template.Core.Managers.Base;
using API_Template.Infrastructure.DataTransfer.Base.DTO;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Template.Infrastructure.DataTransfer.Base.Adapter
{
    public abstract class BaseAdapter<TEntity, TDTO, TManager>: IAdapter<TEntity, TDTO>
        where TManager : class, IManager<TEntity>
        where TDTO : BaseDTO
        where TEntity: IBaseModel
    {
        protected readonly TManager dataManager;
        protected readonly IMapper mapper;

        public BaseAdapter(TManager dataManager, IMapper mapper)
        {
            this.dataManager = dataManager;
            this.mapper = mapper;
        }

        public TDTO ToDTO(TEntity entity)
        {
            return this.mapper.Map<TDTO>(entity);
        }

        public ListDTO<TDTO> ToQueryableDTO(IQueryable<TEntity> queryable)
        {
            IQueryable<TDTO> queryableDTOs = this.mapper.ProjectTo<TDTO>(queryable);
            return new ListDTO<TDTO>(queryableDTOs);
        }

        public virtual async Task<TDTO> GetAsync(Guid id)
        {
            TEntity? entity = await this.dataManager.GetAsync(id);
            if (entity is null)
                return default;
            else
                return ToDTO(entity);

        }

        public virtual ListDTO<TDTO> GetList() => this.ToQueryableDTO(this.dataManager.GetList(q => q));


    }
}
