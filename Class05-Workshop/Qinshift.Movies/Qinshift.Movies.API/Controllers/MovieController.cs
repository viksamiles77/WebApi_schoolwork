using Microsoft.AspNetCore.Mvc;
using Qinshift.Movies.DTOs;
using Qinshift.Movies.Services;
using Qinshift.Movies.Services.Implementation;

namespace Qinshift.Movies.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _movieService = new MovieService();

        [HttpGet]
        public IActionResult GetAllMovies()
        {
            var movies = _movieService.GetAllMovies();
            var movieDtos = MovieMapper.ToMovieDtoList(movies);

            return Ok(movieDtos);
        }

        [HttpGet("{id}")]
        public IActionResult GetMovieById(int id)
        {
            var movie = _movieService.GetMovieById(id);
            if (movie == null)
            {
                return NotFound();
            }
            var movieDto = MovieMapper.ToMovieDto(movie);
            return Ok(movieDto);
        }

        [HttpGet("filter/genre")]
        public IActionResult GetMovieByGenre([FromQuery] string genre)
        {
            try
            {
                if (string.IsNullOrEmpty(genre))
                {
                    return BadRequest("You have to send at least one parameter!");
                }

                var movies = _movieService.FilterMoviesByGenre(genre);

                var movieDtos = MovieMapper.ToMovieDtoList(movies);
                return Ok(movieDtos);

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occured! Contact the admin!");
            }
        }

        [HttpGet("filter/year")]
        public IActionResult GetMovieByYear([FromQuery] int year)
        {
            var movies = _movieService.FilterMoviesByYear(year);

            var movieDtos = MovieMapper.ToMovieDtoList(movies);
            return Ok(movieDtos);
        }

        [HttpPut]
        public IActionResult UpdateMovie([FromBody] MovieCreateDto movieCreateDto)
        {
            var movie = MovieMapper.ToMovie(movieCreateDto);
            _movieService.UpdateMovie(movie);
            return Ok(movie);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteMovieById(int id)
        {
            _movieService.DeleteMovieById(id);
            return Ok();
        }

        [HttpDelete("byBody")]
        public IActionResult DeleteMovieByIdFromBody([FromBody] int id)
        {
            _movieService.DeleteMovieByIdFromBody(id);
            return Ok();
        }
    }
}
