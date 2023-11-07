using API_Template.Controllers.Base;
using API_Template.Core.DataModels.User;
using API_Template.Infrastructure.DataTransfer.User;
using Microsoft.AspNetCore.Mvc;

namespace API_Template.Controllers
{
    public class UsersController : BaseCrudController<UserInfo, UserDTO, ModifyUserDTO>
    {
        public UsersController(UserAdapter userAdapter): base(userAdapter)
        {
        }
    }
}
