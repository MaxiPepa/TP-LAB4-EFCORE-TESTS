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

            public override bool Equals(object? obj)
            {
                return Equals(obj as MovieItem);
            }

            public bool Equals(MovieItem other)
            {
                return Name.Equals(other.Name) && Genre.Equals(other.Genre) && Duration.Equals(other.Duration) && Budget.Equals(other.Budget);
            }
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as GetMoviesResponse);
        }

        public bool Equals(GetMoviesResponse other) 
        { 
            return Movies.SequenceEqual(other.Movies);
        }
    }
}