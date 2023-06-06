using TP_LAB4_EFCORE_TESTS.Models;

namespace TP_LAB4_EFCORE_TESTS.Services
{
    public interface IMovieService
    {
        public GetMoviesResponse GetMovies();

        public GetMovieDataResponse GetMovieData(GetMovieDataRequest rq);

        public GetMovieActorsResponse GetMovieActors(GetMovieActorsRequest rq);


    }
}
