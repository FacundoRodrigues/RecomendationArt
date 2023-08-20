using MediatR;

namespace Modules.Recommendation.Core.Features.DeleteRecommendation
{
    public class CancelRecommendationRequest : IRequest
    {
        public int Id { get; set; }
    }
}