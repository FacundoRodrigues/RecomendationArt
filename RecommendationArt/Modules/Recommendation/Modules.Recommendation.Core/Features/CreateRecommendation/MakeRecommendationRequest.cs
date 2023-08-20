using MediatR;
using Modules.Recommendation.Core.Model;

namespace Modules.Recommendation.Core.Features.CreateRecommendation
{
    public class MakeRecommendationRequest : IRequest<MakeRecommendationResponse>
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public double TrueRating { get; set; }
        public double JokeRating { get; set; }
        public string Description { get; set; }
        public string Platform { get; set; }
        public string Occasion { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedDate { get; set; }
    }

    public class MakeRecommendationResponse
    {
        public RecommendationModel Recommendation { get; set; }
    }
}