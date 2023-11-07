using API_Template.Core.DataModels.Base;
using API_Template.Infrastructure.DataTransfer.Base.Adapter;
using API_Template.Infrastructure.DataTransfer.Base.DTO;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace API_Template.Controllers.Base
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseCrudController<TEntity, TDTO, TModifyDTO> : ControllerBase
        where TEntity : BaseModel
        where TDTO : BaseDTO
        where TModifyDTO: class
    {   
        protected readonly IAdapter<TEntity, TDTO, TModifyDTO> adapter;

        public BaseCrudController(IAdapter<TEntity, TDTO, TModifyDTO> adapter)
        {
            this.adapter = adapter;
        }

        [HttpGet("")]
        public virtual IActionResult GetList()
        {
            var response = this.adapter.GetList();
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async virtual Task<IActionResult> Get([FromRoute]Guid id)
        {
            var response = await this.adapter.GetAsync(id);
            return Ok(response);
        }

        [HttpPost()]
        public async virtual Task<IActionResult> Create([FromBody]TModifyDTO modifyDto)
        {
            await this.adapter.Create(modifyDto);
            return Ok();
        }

        [HttpDelete()]
        public async virtual Task<IActionResult> Delete([FromRoute]Guid id)
        {
            await this.adapter.Delete(id);
            return Ok();
        }
    }
}
