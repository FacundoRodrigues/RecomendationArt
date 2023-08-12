using MediatR;
using Modules.Recommendation.Core.Model;

namespace Modules.Recommendation.Core.Features.UpdateRecommendation
{
    public class UpdateRecommendationRequest : IRequest<UpdateRecommendationResponse>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public double TrueRating { get; set; }
        public double JokeRating { get; set; }
        public string Description { get; set; }
        public string Platform { get; set; }
        public string Occasion { get; set; }
        public int UserId { get; set; }
    }

    public class UpdateRecommendationResponse
    {
        public RecommendationModel Recommendation { get; set; }
    }
}