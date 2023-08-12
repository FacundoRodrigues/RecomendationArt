namespace Modules.Recommendation.Core.Entities
{
    public class Recommendation
    {
        public int Id { get; protected set; }
        public string Title { get; protected set; }
        public string Url { get; protected set; }
        public double TrueRating { get; protected set; }
        public double JokeRating { get; protected set; }
        public string Description { get; protected set; }
        public string Platform { get; protected set; }
        public string Occasion { get; protected set; }
        public int UserId { get; protected set; }
        public DateTime CreatedDate { get; protected set; }

        public Recommendation(string title, string url, double trueRating, double jokeRating, string description, string platform, string occasion, int userId, DateTime createdDate)
        {
            //TODO: agregar Ardalis.GuardClauses

            Title = title;
            Url = url;
            TrueRating = trueRating;
            JokeRating = jokeRating;
            Description = description;
            Platform = platform;
            Occasion = occasion;
            UserId = userId;
            CreatedDate = createdDate;
        }
    }
}