using MediatR;
using Microsoft.EntityFrameworkCore;
using Modules.Recommendation.Core.Abstractions;
using Modules.Recommendation.Core.Mapping;

namespace Modules.Recommendation.Core.Features.UpdateRecommendation
{
    public class UpdateRecommendationHandler : IRequestHandler<UpdateRecommendationRequest, UpdateRecommendationResponse>
    {
        private readonly IRecommendationDbContext _context;

        public UpdateRecommendationHandler(IRecommendationDbContext context)
        {
            _context = context;
        }

        public async Task<UpdateRecommendationResponse> Handle(UpdateRecommendationRequest request, CancellationToken cancellationToken)
        {
            var recommendation = await _context.Recommendations.FirstOrDefaultAsync(x => x.Id == request.Id);

            if (recommendation == null) throw new NullReferenceException();

            recommendation.Update(request.Title, request.Url, request.TrueRating, request.JokeRating, request.Description, request.Platform, request.Occasion, request.UserId);

            _context.Recommendations.Update(recommendation);

            await _context.SaveChangesAsync(cancellationToken);

            return new UpdateRecommendationResponse { Recommendation = recommendation.ToModel() };
        }
    }
}