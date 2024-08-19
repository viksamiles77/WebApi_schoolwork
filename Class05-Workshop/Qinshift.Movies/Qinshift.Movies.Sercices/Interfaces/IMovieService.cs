using Qinshift.Movies.DomainModels;

namespace Qinshift.Movies.Services.Implementation
{
    public interface IMovieService
    {
        List<Movie> GetAllMovies();
        Movie GetMovieById(int id);
        List<Movie> FilterMoviesByGenre(string genre);
        List<Movie> FilterMoviesByYear(int year);
        Movie UpdateMovie(Movie movie);
        void DeleteMovieById(int id);
        void DeleteMovieByIdFromBody(int id);
    }
}
