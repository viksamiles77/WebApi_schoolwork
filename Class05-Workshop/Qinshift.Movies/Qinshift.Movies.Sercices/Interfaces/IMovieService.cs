using Qinshift.Movies.DomainModels;
using Qinshift.Movies.DTOs;

namespace Qinshift.Movies.Services.Implementation
{
    public interface IMovieService
    {
        List<MovieDto> GetAllMovies();
        MovieDto GetMovieById(int id);
        List<MovieDto> FilterMoviesByGenre(string genre);
        List<Movie> FilterMoviesByYear(int year);
        int AddNewMovie(MovieCreateDto movie);
        Movie UpdateMovie(Movie movie);
        int DeleteMovieById(int id);
        void DeleteMovieByIdFromBody(int id);
    }
}
