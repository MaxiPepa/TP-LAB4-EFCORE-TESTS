namespace TP_LAB4_EFCORE_TESTS.Data.Entities
{
    public class Actor
    {
        public int ActorId { get; set; }
        public string ActorName { get; set; }
        public string ActorPicture { get; set; }
        public DateTime ActorBirthDate { get; set; }

        public List<Movie> Movies { get; set; }

        public Actor(int actorId, string actorName, string actorPicture, DateTime actorBirthDate, List<Movie> movies)
        {
            ActorId = actorId;
            ActorName = actorName;
            ActorPicture = actorPicture;
            ActorBirthDate = actorBirthDate;
            Movies = movies;
        }

        public Actor(int actorId, string actorName, string actorPicture, DateTime actorBirthDate)
        {
            ActorId = actorId;
            ActorName = actorName;
            ActorPicture = actorPicture;
            ActorBirthDate = actorBirthDate;
            Movies = new List<Movie>();
        }
    }
}

