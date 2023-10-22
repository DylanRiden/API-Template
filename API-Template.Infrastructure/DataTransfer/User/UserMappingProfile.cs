using API_Template.Core.DataModels.User;
using API_Template.Infrastructure.DataTransfer.Base;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Template.Infrastructure.DataTransfer.User
{
    public class UserMappingProfile : BaseMappingProfile<UserDTO, IUser>
    {
        public UserMappingProfile(): base()
        {
        }
    }
}
