using TP_LAB4_EFCORE_TESTS.Data.Entities.Repository;
using TP_LAB4_EFCORE_TESTS.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TP_LAB4_EFCORE_TESTS.Data.Entities;
using TP_LAB4_EFCORE_TESTS.Models;

namespace TP_LAB4_EFCORE_TESTS.Tests
{
    [TestClass]
    public class MovieServiceTest
    {
        private List<Movie> Movies;
        private IMovieService _movieService;
        private Mock<IMovieRepository> _movieRepository;

        private GetMoviesResponse _getMoviesResponse;
        private GetMovieDataResponse _getMovieDataResponse;
        private GetMovieActorsResponse _getMovieActorsResponse;

        [TestInitialize]
        public void Initialize()
        {
            Movies = new()
            {
                new Movie(1, "Spiderman Homecoming", "Action", 2.15, 175000000, new List<Actor>
                {
                    new Actor(1, "Tom Holland", "Picture", new DateTime(1996, 06, 01)),
                    new Actor(2, "Zendaya", "Picture", new DateTime(1996,09, 01)),
                    new Actor(3, "Robert Downey Jr.", "Picture", new DateTime(1965, 04, 04))
                }),

                new Movie(2, "Megan", "Horror/Cience Fiction", 1.75, 12000000, new List<Actor>
                {
                    new Actor(4, "Amie Donald", "Picture", new DateTime(2010, 01, 28)),
                    new Actor(5, "Allison Williams", "Picture", new DateTime(1998, 04, 13)),
                    new Actor(6, "Violet McGraw", "Picture", new DateTime(2011, 04, 22))
                }),

                new Movie(3, "Midsommar", "Horror", 3, 9000000, new List<Actor>
                {
                    new Actor(7, "Florence Pugh", "Picture", new DateTime(1996, 01, 03)),
                    new Actor(8, "Will Poulter", "Picture", new DateTime(1993, 01, 28)),
                    new Actor(9, "Jack Reynor", "Picture", new DateTime(1992, 01, 23))
                })
            };
            _getMoviesResponse = new GetMoviesResponse();
            _getMovieDataResponse = new GetMovieDataResponse();
            _getMovieActorsResponse = new GetMovieActorsResponse();

            _movieRepository = new Mock<IMovieRepository>(MockBehavior.Strict);
            _movieService = new MovieService(_movieRepository.Object);

            _movieRepository.Setup(m => m.GetAll()).Returns(Movies);
            _movieRepository.Setup(m => m.GetOne(1)).Returns(Movies[0]);
            _movieRepository.Setup(m => m.GetOne(It.IsAny<int>())).Returns(Movies[0]);
            _movieRepository.Setup(m => m.GetOne(It.IsAny<int>())).Returns<int>(id => Movies[id - 1]);
        }

        [TestMethod]
        public void GetMovies()
        {
            _getMoviesResponse.Movies = Movies.Select(x => new GetMoviesResponse.MovieItem
            {
                Name = x.MovieName,
                Genre = x.MovieGenre,
                Duration = x.MovieDuration,
                Budget = x.MovieBudget,
                ActorNames = x.Actors.Select(a => a.ActorName).ToList(),
            }).ToList();

            GetMoviesResponse response = _movieService.GetMovies();

            Assert.AreEqual(_getMoviesResponse, response);
        }

        [TestMethod]
        public void GetMovieData()
        {
            var movie = Movies[0];

            _getMovieDataResponse = new GetMovieDataResponse
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

            GetMovieDataResponse response = _movieService.GetMovieData(new GetMovieDataRequest() { MovieId = 1 });

            Assert.AreEqual(_getMovieDataResponse, response);
        }

        [TestMethod]
        public void GetMovieActors()
        {
            var movie = Movies[0];

            _getMovieActorsResponse = new GetMovieActorsResponse
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

            GetMovieActorsResponse response = _movieService.GetMovieActors(new GetMovieActorsRequest() { MovieId = 1 });

            Assert.AreEqual(_getMovieActorsResponse, response);
        }
    }
}
