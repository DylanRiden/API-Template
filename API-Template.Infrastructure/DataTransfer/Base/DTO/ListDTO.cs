using API_Template.Infrastructure.DataTransfer.Base.Meta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Template.Infrastructure.DataTransfer.Base.DTO
{
    public class ListDTO<TDTO>
        where TDTO: BaseDTO
    {
        public ListDTO(IQueryable<TDTO> queryableEntities)
        {
            this.Data = queryableEntities;
            this.Metadata = new(Data);
        }

        public IQueryable<TDTO> Data { get; set; }

        public ListMetadata<TDTO> Metadata { get; set; }
    }
}
