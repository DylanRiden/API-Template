using API_Template.Infrastructure.DataTransfer.Base.DTO;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Template.Infrastructure.DataTransfer.Base
{
    public class BaseMappingProfile<TDTO, TEntity>: Profile
        where TDTO: BaseDTO<TEntity>
    {
        public BaseMappingProfile(): base()
        {
            CreateMap<TDTO, TEntity>();
        }
    }
}
