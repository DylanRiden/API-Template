using API_Template.Core.DataModels.Base;
using API_Template.Infrastructure.DataTransfer.Base.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Template.Infrastructure.DataTransfer.Base.Adapter
{
    public interface IAdapter<TEntity, TReadDTO, TModifyDTO>
        where TReadDTO: BaseDTO
        where TEntity: BaseModel
        where TModifyDTO: class
    {
        public TReadDTO ToDTO(TEntity entity);

        public TEntity FromDTO(TModifyDTO dto);

        public ListDTO<TReadDTO> ToQueryableDTO(IQueryable<TEntity> queryable);

        public Task<TReadDTO> GetAsync(Guid id);

        public ListDTO<TReadDTO> GetList();

        public Task Create(TModifyDTO modifyDTO);

        public Task Replace(Guid Id, TModifyDTO modifyDTO);

        public Task Update(Guid Id, TModifyDTO modifyDTO);

        public Task Delete(Guid id);
    }
}
