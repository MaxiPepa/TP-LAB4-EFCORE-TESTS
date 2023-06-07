namespace TP_LAB4_EFCORE_TESTS.Data.Entities.Repository
{
    public class MovieRepository : IMovieRepository
    {
        public readonly FakeDB _fakeDB;
        public MovieRepository(FakeDB fakeDB) 
        {
            _fakeDB = fakeDB;
        }

        public List<Movie> GetAll()
        {
            return _fakeDB.Movies.ToList();
        }

        public Movie? GetOne(int movieId)
        {
            return _fakeDB.Movies.FirstOrDefault(x => x.MovieId == movieId);
        }
    }
}
