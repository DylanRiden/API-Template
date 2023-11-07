using API_Template.Core.DataModels.User;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Template.Core
{
    public class AppDataContext: DbContext
    {
        public DbSet<UserInfo> Users { get; set; }

        public AppDataContext(DbContextOptions options): base(options)
        {
            
        }
    }
}
