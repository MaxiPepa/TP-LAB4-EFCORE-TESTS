namespace TP_LAB4_EFCORE_TESTS.Data.Entities.Repository
{
    public interface IMovieRepository
    {
        List<Movie> GetAll();
        Movie? GetOne(int movieId);
    }
}
