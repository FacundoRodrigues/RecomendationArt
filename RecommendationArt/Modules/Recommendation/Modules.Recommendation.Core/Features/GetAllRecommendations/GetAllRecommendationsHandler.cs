using MediatR;
using Microsoft.EntityFrameworkCore;
using Modules.Recommendation.Core.Abstractions;
using Modules.Recommendation.Core.Mapping;

namespace Modules.Recommendation.Core.Features.GetAllRecommendations
{
    public class GetAllRecommendationsHandler : IRequestHandler<GetAllRecommendationsRequest, GetAllRecommendationsResponse>
    {
        private readonly IRecommendationDbContext _context;

        public GetAllRecommendationsHandler(IRecommendationDbContext context)
        {
            _context = context;
        }

        public async Task<GetAllRecommendationsResponse> Handle(GetAllRecommendationsRequest request, CancellationToken cancellationToken)
        {
            //Esto se va a mostrar en un feed, por eso solo se toman las últimas 1000 recomendaciones.
            var recommendations = await _context.Recommendations.OrderByDescending(x => x.Id).Take(1000).ToListAsync();

            return new GetAllRecommendationsResponse { Recommendations = recommendations.ToModel() };
        }
    }
}