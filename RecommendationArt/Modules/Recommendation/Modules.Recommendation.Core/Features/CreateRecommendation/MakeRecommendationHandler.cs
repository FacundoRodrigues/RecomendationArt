using MediatR;
using Modules.Recommendation.Core.Abstractions;
using Modules.Recommendation.Core.Mapping;

namespace Modules.Recommendation.Core.Features.CreateRecommendation
{
    public class MakeRecommendationHandler : IRequestHandler<MakeRecommendationRequest, MakeRecommendationResponse>
    {
        private readonly IRecommendationDbContext _context;

        public MakeRecommendationHandler(IRecommendationDbContext context)
        {
            _context = context;
        }

        public async Task<MakeRecommendationResponse> Handle(MakeRecommendationRequest request, CancellationToken cancellationToken)
        {
            var recommendation = new Entities.Recommendation(request.Title, request.Url, request.TrueRating, request.JokeRating, request.Description, request.Platform, request.Occasion, request.UserId, request.CreatedDate);

            _context.Recommendations.Add(recommendation);

            await _context.SaveChangesAsync(cancellationToken);

            return new MakeRecommendationResponse { Recommendation = recommendation.ToModel() };
        }
    }
}