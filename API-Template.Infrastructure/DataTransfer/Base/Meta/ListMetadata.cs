using API_Template.Infrastructure.DataTransfer.Base.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Template.Infrastructure.DataTransfer.Base.Meta
{
    public class ListMetadata<TDTO>
        where TDTO : BaseDTO
    {
        public int Count { get; }

        public ListMetadata(IEnumerable<TDTO> enumerable)
        {
            this.Count = enumerable.Count();
        }
        
        //Limit, Skip, etc TODO

    }
}
