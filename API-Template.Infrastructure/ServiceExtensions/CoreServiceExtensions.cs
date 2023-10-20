using API_Template.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Template.Infrastructure.ServiceExtensions
{
    public static class CoreServiceExtensions
    {
        public static IServiceCollection AddCoreServices(this IServiceCollection services)
        {
            services.AddDbContext<AppDataContext>(opt => opt.UseSqlite("Data Source=Z:\\Dev\\Practice\\DBs\\template.db"));
            services.AddManagers();
            services.AddValidators();
            return services;
        }

        private static IServiceCollection AddManagers(this IServiceCollection services)
        {
            return services;
        }

        private static IServiceCollection AddValidators(this IServiceCollection services)
        {
            
            return services;
        }
    }
}
