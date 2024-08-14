using Qinshift.Movies.DomainModels;
using Qinshift.Movies.DomainModels.Enums;

namespace Qinshift.Movies.Services.Implementation
{
    public interface IMovieService
    {
        List<Movie> GetAllMovies();
        Movie GetMovieById(int id);
        List<Movie> FilterMoviesByGenre(string genre);
        List<Movie> FilterMoviesByYear(int year);
        void UpdateMovie(Movie movie);
        void DeleteMovieById(int id);
        void DeleteMovieByIdFromBody(int id);
    }
}
