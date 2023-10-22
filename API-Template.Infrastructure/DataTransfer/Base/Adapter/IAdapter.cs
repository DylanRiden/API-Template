using API_Template.Core.DataModels.Base;
using API_Template.Infrastructure.DataTransfer.Base.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Template.Infrastructure.DataTransfer.Base.Adapter
{
    public interface IAdapter<TEntity, TDTO>
        where TDTO: BaseDTO
        where TEntity: BaseModel
    {
        public TDTO ToDTO(TEntity entity);

        public ListDTO<TDTO> ToQueryableDTO(IQueryable<TEntity> queryable);

        public Task<TDTO> GetAsync(Guid id);

        public ListDTO<TDTO> GetList();
    }
}
