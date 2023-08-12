namespace Modules.Recommendation.Core.Mapping
{
    public static class RecommendationMappingExtensions
    {
        public static List<Model.RecommendationModel> ToModel(this List<Entities.Recommendation> recommendations)
        {
            return recommendations.Select(x => x.ToModel()).ToList();
        }

        public static Model.RecommendationModel ToModel(this Entities.Recommendation recommendation)
        {
            return new Model.RecommendationModel
            {
                Id = recommendation.Id,
                CreatedDate = recommendation.CreatedDate,
                Description = recommendation.Description,
                JokeRating = recommendation.JokeRating,
                Occasion = recommendation.Occasion,
                Platform = recommendation.Platform,
                Title = recommendation.Title,
                TrueRating = recommendation.TrueRating,
                Url = recommendation.Url,
                UserId = recommendation.UserId
            };
        }
    }
}