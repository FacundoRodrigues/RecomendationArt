using MediatR;

namespace Modules.Recommendation.Core.Features.GetAllRecommendations
{
    public class GetAllRecommendationsRequest : IRequest<GetAllRecommendationsResponse>
    {
    }

    public class GetAllRecommendationsResponse
    {
        public List<Model.RecommendationModel> Recommendations { get; set; }
    }
}