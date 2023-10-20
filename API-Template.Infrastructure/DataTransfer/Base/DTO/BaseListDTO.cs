using API_Template.Infrastructure.DataTransfer.Base.Meta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Template.Infrastructure.DataTransfer.Base.DTO
{
    public class BaseListDTO<TData, TMetadata>
        where TData : class
        where TMetadata : BaseListMetadata<TData>
    {
        public IEnumerable<TData> Data { get; set; }
        public TMetadata Metadata { get; set; }
    }
    public class BaseListDTO<TData> : BaseListDTO<TData, BaseListMetadata<TData>>
        where TData : class
    { }
}
