using MediatR;
using Microsoft.EntityFrameworkCore;
using Modules.Recommendation.Core.Abstractions;

namespace Modules.Recommendation.Core.Features.DeleteRecommendation
{
    public class CancelRecommendationHandler : IRequestHandler<CancelRecommendationRequest>
    {
        private readonly IRecommendationDbContext _context;

        public CancelRecommendationHandler(IRecommendationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(CancelRecommendationRequest request, CancellationToken cancellationToken)
        {
            var recommendation = await _context.Recommendations.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken: cancellationToken);

            if (recommendation == null) throw new NullReferenceException();

            _context.Recommendations.Remove(recommendation);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}