using API_Template.Core.DataModels.User;
using API_Template.Core.Managers.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Template.Core.Managers.User
{
    internal class UserManager : BaseManager<UserInfo>, IUserManager
    {
        public UserManager(AppDataContext dataContext) : base(dataContext)
        {
        }

        protected override DbSet<UserInfo> GetDbSet()
        {
            return this.dataContext.Users;
        }

        public async Task OnLoginAsync(UserInfo user)
        {
            //Example
            user.LastLoggedIn = DateTime.UtcNow;
            this.dataSet.Update(user);
            await this.dataContext.SaveChangesAsync();
        }
        
    }
}
