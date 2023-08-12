namespace Modules.Recommendation.Core.Dto
{
    public class UpdateRecommendationDto
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
}