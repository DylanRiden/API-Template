using Microsoft.AspNetCore.Mvc;

namespace API_Template.Controllers.Base
{
    public abstract class BaseCRUDController: ControllerBase
    {
        public BaseCRUDController()
        {

        }

        [HttpGet("{id}")]
        public virtual IActionResult Get([FromRoute]Guid id)
        {
            return Ok(id);
        }        
    }
}
