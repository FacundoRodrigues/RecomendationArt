namespace Modules.Recommendation.Core.Model
{
    public class RecommendationModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public double TrueRating { get; set; }
        public string JokeRating { get; set; }
        public string Description { get; set; }
        public string Platform { get; set; }
        public string Occasion { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}