using Microsoft.EntityFrameworkCore;
using Modules.Recommendation.Core.Abstractions;

namespace Modules.Recommendation.Infrastructure.Persistence
{
    public class RecommendationDbContext : ModuleDbContext, IRecommendationDbContext
    {
        public RecommendationDbContext(DbContextOptions<RecommendationDbContext> options) : base(options)
        {
        }
        public DbSet<Core.Entities.Recommendation> Recommendations { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
