using API_Template.Infrastructure.DataTransfer.Base.DTO;
using AutoMapper;
using Microsoft.EntityFrameworkCore.Sqlite.Storage.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Template.Infrastructure.DataTransfer.Base
{
    public abstract class BaseMappingProfile<TDTO, TEntity>: Profile
        where TDTO: BaseDTO
    {
        public BaseMappingProfile(): base()
        {
            CreateMap<TEntity, TDTO>();
            //Creates etc???
        }
    }
}
