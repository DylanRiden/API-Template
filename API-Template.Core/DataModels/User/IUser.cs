﻿using API_Template.Core.DataModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Template.Core.DataModels.User
{
    public interface IUser: IBaseModel
    {
        public string FirstName { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }
        
        public DateTime LastLoggedIn { get; set; }
        

        public string FullName => FirstName + " " + Surname;


    }
}
