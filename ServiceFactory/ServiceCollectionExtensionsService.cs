using Microsoft.Extensions.DependencyInjection;
using ServiceLibrary;
using ServiceLibrary.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceFactory
{
    public static class ServiceCollectionExtensionsService
    {
        
        public static IServiceCollection AddService(this IServiceCollection services)
        {
            services.AddScoped<IMailService, MailService>();
            return services;
        }

    }
}
