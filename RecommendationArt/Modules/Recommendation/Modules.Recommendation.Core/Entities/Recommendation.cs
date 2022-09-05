namespace Modules.Recommendation.Core.Entities
{
    public class Recommendation
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public double TrueRating { get; set; }
        public string JokeRating { get; set; }
        public string Description { get; set; } 
        public string Platform { get; set; }
        public string Occasion { get; set; }
    }
}
