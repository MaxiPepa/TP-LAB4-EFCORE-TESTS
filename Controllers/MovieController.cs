using Microsoft.AspNetCore.Mvc;
using TP_LAB4_EFCORE_TESTS.Models;
using TP_LAB4_EFCORE_TESTS.Services;

namespace TP_LAB4_EFCORE_TESTS.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class MovieController : Controller
    {
        #region Constructor
        private readonly IMovieService _movieService;

        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }
        #endregion

        #region Movie
        [HttpGet]
        public IActionResult GetMovies()
        {
            return Ok(_movieService.GetMovies());
        }

        [HttpGet]
        public IActionResult GetMovieData([FromQuery] GetMovieDataRequest rq)
        {
            var rsp = _movieService.GetMovieData(rq);

            if (rsp.Success)
                return Ok(rsp);
            else
                return BadRequest(rsp);

        }

        [HttpGet]
        public IActionResult GetMovieActors([FromQuery] GetMovieActorsRequest rq)
        {
            var rsp = _movieService.GetMovieActors(rq);

            if (rsp.Success)
                return Ok(rsp);
            else
                return BadRequest(rsp);
        }

        #endregion
    }
}