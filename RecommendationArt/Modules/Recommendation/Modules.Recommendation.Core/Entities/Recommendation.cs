namespace Modules.Recommendation.Core.Entities
{
    public class Recommendation
    {
        public int Id { get; protected set; }
        public string Title { get; protected set; }
        public string Url { get; protected set; }
        public double TrueRating { get; protected set; }
        public string JokeRating { get; protected set; }
        public string Description { get; protected set; }
        public string Platform { get; protected set; }
        public string Occasion { get; protected set; }
        public int UserId { get; protected set; }
        public DateTime CreatedDate { get; protected set; }
    }
}