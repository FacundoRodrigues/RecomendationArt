using Microsoft.EntityFrameworkCore;

namespace Modules.Recommendation.Core.Abstractions
{
    public interface IRecommendationDbContext
    {
        public DbSet<Entities.Recommendation> Recommendations { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}