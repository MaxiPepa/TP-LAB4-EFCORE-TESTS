namespace TP_LAB4_EFCORE_TESTS.Models
{
    public class GetMovieDataRequest
    {
        public int MovieId { get; set; }
    }

    public class GetMovieDataResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public MovieItem Movie { get; set; }

        public class MovieItem
        {
            public string Name { get; set; }
            public string Genre { get; set; }
            public double Duration { get; set; }
            public double Budget { get; set; }
            public List<ActorItem> Actors { get; set; }
        }

        public class ActorItem
        {
            public string Name { get; set; }
            public string Picture { get; set; }
            public DateTime BirthDate { get; set; }
        }
    }
}