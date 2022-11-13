using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Modules.Recommendation.Core.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddRecommendationCore(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}