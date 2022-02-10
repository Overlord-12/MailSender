using Microsoft.Extensions.DependencyInjection;
using RepositoryLibrary;
using RepositoryLibrary.Interace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceFactory
{
    public static class ServiceCollectionExtensionsRepository
    {
        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddScoped<IMailRepository, MailRepository>();
            return services;
        }
    }
}
