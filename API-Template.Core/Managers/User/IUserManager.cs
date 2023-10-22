using API_Template.Core.DataModels.User;
using API_Template.Core.Managers.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Template.Core.Managers.User
{
    public interface IUserManager: IManager<UserInfo>
    {
        public Task OnLoginAsync(UserInfo user);
    }
}
