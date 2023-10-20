using API_Template.Core.DataModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Template.Core.DataModels
{
    public class User: BaseDbModel
    {
        public string Email { get; set; }

        public DateTime LastLoggedIn { get; set; }

        //Navigation

        
    }
}
