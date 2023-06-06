namespace TP_LAB4_EFCORE_TESTS.Models
{
    public class GetMovieActorsRequest
    {
        public int MovieId { get; set; }
    }

    public class GetMovieActorsResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public List<ActorItem> Actors { get; set; }

        public class ActorItem
        {
            public string Name { get; set; }
            public string Picture { get; set; }
            public DateTime BirthDate { get; set; }
        }
    }
}