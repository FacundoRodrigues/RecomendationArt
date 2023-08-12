using MediatR;
using Modules.Recommendation.Core.Abstractions;
using Modules.Recommendation.Core.Mapping;

namespace Modules.Recommendation.Core.Features.CreateRecommendation
{
    public class CreateRecommendationHandler : IRequestHandler<CreateRecommendationRequest, CreateRecommendationResponse>
    {
        private readonly IRecommendationDbContext _context;

        public CreateRecommendationHandler(IRecommendationDbContext context)
        {
            _context = context;
        }

        public async Task<CreateRecommendationResponse> Handle(CreateRecommendationRequest request, CancellationToken cancellationToken)
        {
            var recommendation = new Entities.Recommendation(request.Title, request.Url, request.TrueRating, request.JokeRating, request.Description, request.Platform, request.Occasion, request.UserId, request.CreatedDate);

            _context.Recommendations.Add(recommendation);

            await _context.SaveChangesAsync(cancellationToken);

            return new CreateRecommendationResponse { Recommendation = recommendation.ToModel() };
        }
    }
}