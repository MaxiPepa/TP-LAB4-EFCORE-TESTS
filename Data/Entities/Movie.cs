namespace TP_LAB4_EFCORE_TESTS.Data.Entities
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public string MovieGenre { get; set; }
        public double MovieDuration { get; set; }
        public double MovieBudget { get; set; }


        public List<Actor> Actors { get; set; }

        public Movie(int movieId, string movieName, string movieGenre, double movieDuration, double movieBudget, List<Actor> actors)
        {
            MovieId = movieId;
            MovieName = movieName;
            MovieGenre = movieGenre;
            MovieDuration = movieDuration;
            MovieBudget = movieBudget;
            Actors = actors;
        }
    }
}
