using TP_LAB4_EFCORE_TESTS.Data.Entities;

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

            public override bool Equals(object? obj)
            {
                return Equals(obj as MovieItem);
            }

            public bool Equals(MovieItem other)
            {
                return Name.Equals(other.Name) && Genre.Equals(other.Genre) && Duration.Equals(other.Duration) && Budget.Equals(other.Budget);
            }
        }

        public class ActorItem
        {
            public string Name { get; set; }
            public string Picture { get; set; }
            public DateTime BirthDate { get; set; }
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as GetMovieDataResponse);
        }

        public bool Equals(GetMovieDataResponse other)
        {
            return Movie.Equals(other.Movie);
        }
    }
}