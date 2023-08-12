using MediatR;
using Microsoft.EntityFrameworkCore;
using Modules.Recommendation.Core.Abstractions;
using Modules.Recommendation.Core.Mapping;

namespace Modules.Recommendation.Core.Features.GetRecommedationById
{
    public class GetRecommedationByIdHandler : IRequestHandler<GetRecommedationByIdRequest, GetRecommedationByIdResponse>
    {
        private readonly IRecommendationDbContext _context;

        public GetRecommedationByIdHandler(IRecommendationDbContext context)
        {
            _context = context;
        }

        public async Task<GetRecommedationByIdResponse> Handle(GetRecommedationByIdRequest request, CancellationToken cancellationToken)
        {
            var recommendation = await _context.Recommendations.FirstOrDefaultAsync(x => x.Id == request.Id);

            if (recommendation == null) throw new NullReferenceException();

            return new GetRecommedationByIdResponse { Recommendation = recommendation.ToModel() };
        }
    }
}