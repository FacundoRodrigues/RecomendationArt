using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Modules.Recommendation.Core.Abstractions;
using Modules.Recommendation.Infrastructure.Persistence;
using Shared.Infrastructure.Extensions;

namespace Modules.Recommendation.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddRecommendationInfrastructure(this IServiceCollection services, IConfiguration config)
        {
            services
                .AddDatabaseContext<RecommendationDbContext>(config)
                .AddScoped<IRecommendationDbContext>(provider => provider.GetService<RecommendationDbContext>());
            return services;
        }
    }
}