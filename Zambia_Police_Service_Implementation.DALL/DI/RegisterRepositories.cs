using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zambia_Police_Service_Implementation.DALL.Implementations;
using Zambia_Police_Service_Repository.DALL.Interfaces;

namespace Zambia_Police_Service_Implementation.DALL.DI
{
   public static class RegisterRepositories
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {

           // services.AddSingleton<IService, GenericImplementation>();

            return services;

        }
       
    }
}
