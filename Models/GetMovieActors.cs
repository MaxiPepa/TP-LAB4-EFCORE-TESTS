using TP_LAB4_EFCORE_TESTS.Data.Entities;

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

            public override bool Equals(object? obj)
            {
                return Equals(obj as ActorItem);
            }

            public bool Equals(ActorItem other)
            {
                return Name.Equals(other.Name) && Picture.Equals(other.Picture) && BirthDate.Equals(other.BirthDate);
            }
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as GetMovieActorsResponse);
        }

        public bool Equals(GetMovieActorsResponse other)
        {
            return Actors.SequenceEqual(other.Actors);
        }
    }
}