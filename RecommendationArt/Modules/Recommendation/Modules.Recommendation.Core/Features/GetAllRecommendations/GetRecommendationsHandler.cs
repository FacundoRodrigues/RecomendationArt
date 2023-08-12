using MediatR;
using Microsoft.EntityFrameworkCore;
using Modules.Recommendation.Core.Abstractions;
using Modules.Recommendation.Core.Mapping;

namespace Modules.Recommendation.Core.Features.GetAllRecommendations
{
    public class GetRecommendationsHandler : IRequestHandler<GetAllRecommendationsRequest, GetAllRecommendationsResponse>
    {
        private readonly IRecommendationDbContext _context;

        public GetRecommendationsHandler(IRecommendationDbContext context)
        {
            _context = context;
        }

        public async Task<GetAllRecommendationsResponse> Handle(GetAllRecommendationsRequest request, CancellationToken cancellationToken)
        {
            var recommendations = await _context.Recommendations.ToListAsync();

            return new GetAllRecommendationsResponse { Recommendations = recommendations.ToModel() };
        }
    }
}