using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Posts.Api.Configuration;
using Posts.Infrastructure;

namespace Posts.Api
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddCosmosDb(this IServiceCollection services, ApplicationOptions options)
        {
            services.AddDbContext<ApplicationDbContext>(o => 
                o.UseCosmos(options.CosmosDb.AccountEndpoint, options.CosmosDb.AccountKey, options.CosmosDb.DatabaseName));
            return services;
        }
    }
}
