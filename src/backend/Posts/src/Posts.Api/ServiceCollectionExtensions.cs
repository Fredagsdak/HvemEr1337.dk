using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Posts.Api.Configuration;
using Posts.Application.CommandHandlers;
using Posts.Application.Commands;
using Posts.Domain;
using Posts.Infrastructure;
using Posts.ReadModels;

namespace Posts.Api
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            // add infrastructure
            services.AddScoped<IPostRepository, CosmosPostRepository>();

            // add application
            services.AddScoped<ICommandHandler<CreatePostCommand>, CreatePostCommandHandler>();

            // add read models
            services.AddScoped<IPostQueries, PostQueries>();

            return services;
        }

        public static IServiceCollection AddCosmosDb(this IServiceCollection services, ApplicationOptions options)
        {
            services.AddDbContext<ApplicationDbContext>(o => 
                o.UseCosmos(options.CosmosDb.AccountEndpoint, options.CosmosDb.AccountKey, options.CosmosDb.DatabaseName));
            return services;
        }
    }
}
