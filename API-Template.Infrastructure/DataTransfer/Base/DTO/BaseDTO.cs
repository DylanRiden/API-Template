using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using API_Template.Infrastructure.DataTransfer.Base.Meta;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API_Template.Infrastructure.DataTransfer.Base.DTO
{
    public class BaseDTO
    {
        public Guid Id { get; set; }   
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}
