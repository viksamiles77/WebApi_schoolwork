using Qinshift.Movies.DomainModels;
using Qinshift.Movies.DTOs;

namespace Qinshift.Movies.Services
{
    public static class MovieMapper
    {
        public static MovieDto ToMovieDto(Movie movie)
        {
            return new MovieDto
            {
                Title = movie.Title,
                Description = movie.Description,
                Year = movie.Year,
                Genre = movie.Genre.ToString(),
            };
        }

        public static Movie ToMovie(MovieCreateDto movieCreateDto)
        {
            return new Movie
            {
                Title = movieCreateDto.Title,
                Description = movieCreateDto.Description,
                Year = movieCreateDto.Year,
                Genre = movieCreateDto.Genre,
            };
        }

        public static List<MovieDto> ToMovieDtoList(List<Movie> movies)
        {
            return movies.Select(x => ToMovieDto(x)).ToList();
        }
    }
}
