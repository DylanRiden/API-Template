using API_Template.Core.DataModels.User;
using API_Template.Core.Managers.User;
using API_Template.Infrastructure.DataTransfer.Base.Adapter;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Template.Infrastructure.DataTransfer.User
{
    public class UserAdapter: BaseAdapter<UserInfo, UserDTO, IUserManager>
    {
        public UserAdapter(IUserManager dataManager, IMapper mapper) : base(dataManager, mapper)
        {
        }
    }
}
