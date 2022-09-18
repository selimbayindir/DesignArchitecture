using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public static class ServiceTools
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddScoped<IPersonService, PersonManager>();
            services.AddScoped<IPersonDal, EfPersonDal>();


        }
    }
}
