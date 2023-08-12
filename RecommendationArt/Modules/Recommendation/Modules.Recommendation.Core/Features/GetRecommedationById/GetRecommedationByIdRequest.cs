using MediatR;
using Modules.Recommendation.Core.Model;

namespace Modules.Recommendation.Core.Features.GetRecommedationById
{
    public class GetRecommedationByIdRequest : IRequest<GetRecommedationByIdResponse>
    {
        public int Id { get; set; }
    }

    public class GetRecommedationByIdResponse
    {
        public RecommendationModel Recommendation { get; set; }
    }
}