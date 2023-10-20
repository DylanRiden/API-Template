using API_Template.Infrastructure.DataTransfer.Base.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Template.Infrastructure.DataTransfer.User
{
    public class UserDTO : BaseDTO<Core.DataModels.User>
    {
        public string Email { get; set; }
    }
}

