using TP_LAB4_EFCORE_TESTS.Data;
using TP_LAB4_EFCORE_TESTS.Models;

namespace TP_LAB4_EFCORE_TESTS.Services
{
    public class MovieService : IMovieService
    {
        #region Constructor
        private readonly FakeDB _fakeDB;

        public MovieService(FakeDB fakeDB) 
        {
            _fakeDB = fakeDB;
        }
        #endregion

        #region Movies
        public GetMoviesResponse GetMovies()
        {
            var movies = _fakeDB.Movies
                .ToList();

            return new GetMoviesResponse
            {
                Movies = movies.Select(x => new GetMoviesResponse.MovieItem
                {
                    Name = x.MovieName,
                    Genre = x.MovieGenre,
                    Duration = x.MovieDuration,
                    Budget = x.MovieBudget,
                    ActorNames = x.Actors.Select(a => a.ActorName).ToList(),
                }).ToList(),
            };
        }

        public GetMovieDataResponse GetMovieData(GetMovieDataRequest rq)
        {
            var movie = _fakeDB.Movies
                .FirstOrDefault(x => x.MovieId == rq.MovieId);

            if (movie == null)
            {
                return new GetMovieDataResponse
                {
                    Message = "Movie not found",
                    Success = false,
                };
            }

            return new GetMovieDataResponse
            {
                Success = true,
                Message = "Successfully retrieved Movie Data",
                Movie = new GetMovieDataResponse.MovieItem
                {
                    Name = movie.MovieName,
                    Genre = movie.MovieGenre,
                    Duration = movie.MovieDuration,
                    Budget = movie.MovieBudget,
                    Actors = movie.Actors.Select(a => new GetMovieDataResponse.ActorItem
                    {
                        Name = a.ActorName,
                        Picture = a.ActorPicture,
                        BirthDate = a.ActorBirthDate,
                    }).ToList(),
                }
            };
        }

        public GetMovieActorsResponse GetMovieActors(GetMovieActorsRequest rq)
        {
            var movie = _fakeDB.Movies
                .FirstOrDefault(x => x.MovieId == rq.MovieId);

            if (movie == null)
            {
                return new GetMovieActorsResponse
                {
                    Message = "Movie not found",
                    Success = false,
                };
            }

            return new GetMovieActorsResponse
            {
                Success = true,
                Message = "Successfully retrieved actors",
                Actors = movie.Actors.Select(a => new GetMovieActorsResponse.ActorItem
                {
                    Name = a.ActorName,
                    Picture = a.ActorPicture,
                    BirthDate = a.ActorBirthDate,
                }).ToList(),
            };
        }
        #endregion
    }
}
