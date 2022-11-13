using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Modules.Recommendation.Core.Extensions;
using Modules.Recommendation.Infrastructure.Extensions;

namespace Modules.Recommendation.Extensions
{
    public static class ModuleExtensions
    {
        public static IServiceCollection AddRecommendationModule(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddRecommendationCore()
                .AddRecommendationInfrastructure(configuration);
            return services;
        }
    }
}