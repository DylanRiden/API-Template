using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Template.Infrastructure.DataTransfer.Base.Meta
{
    public class BaseListMetadata<TData>
    where TData : class
    {

        public int Count { get; set; }

        public BaseListMetadata(IEnumerable<TData> enumerable)
        {
            Count = enumerable.Count();
        }
    }
}
