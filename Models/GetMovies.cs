namespace TP_LAB4_EFCORE_TESTS.Models
{
    public class GetMoviesResponse
    {
        public List<MovieItem> Movies { get; set; }

        public class MovieItem
        {
            public string Name { get; set; }
            public string Genre { get; set; }
            public double Duration { get; set; }
            public double Budget { get; set; }
            public List<string> ActorNames { get; set; }
        }
    }
}