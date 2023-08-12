using MediatR;
using Microsoft.EntityFrameworkCore;
using Modules.Recommendation.Core.Abstractions;

namespace Modules.Recommendation.Core.Features.DeleteRecommendation
{
    public class DeleteRecommendationRequest : IRequest
    {
        public int Id { get; set; }
    }

    public class DeleteRecommendationHandler : IRequestHandler<DeleteRecommendationRequest>
    {
        private readonly IRecommendationDbContext _context;

        public DeleteRecommendationHandler(IRecommendationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(DeleteRecommendationRequest request, CancellationToken cancellationToken)
        {
            var recommendation = await _context.Recommendations.FirstOrDefaultAsync(x => x.Id == request.Id);

            if (recommendation == null) throw new NullReferenceException();

            _context.Recommendations.Remove(recommendation);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}