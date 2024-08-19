using Qinshft.Movies.DataAccess;
using Qinshift.Movies.DomainModels;
using Qinshift.Movies.DomainModels.Enums;

namespace Qinshift.Movies.Services.Implementation
{
    public class MovieService : IMovieService
    {
        public List<Movie> GetAllMovies()
        {
            return StaticDb.Movies;
        }

        public Movie GetMovieById(int id)
        {
            return StaticDb.Movies.FirstOrDefault(x => x.Id == id);
        }

        public List<Movie> FilterMoviesByGenre(string genre)
        {
            if (Enum.TryParse<GenreEnum>(genre, true, out var genreEnum))
            {
                return StaticDb.Movies.Where(x => x.Genre == genreEnum).ToList();
            }
            return new List<Movie>();
        }
        public List<Movie> FilterMoviesByYear(int year)
        {
            if (year < 0) { return new List<Movie>(); }
            return StaticDb.Movies.Where(x => x.Year == year).ToList();
        }

        public Movie UpdateMovie(Movie movie)
        {
            var existingMovie = StaticDb.Movies.FirstOrDefault(x => x.Id == movie.Id);
            if (existingMovie != null)
            {
                existingMovie.Title = movie.Title;
                existingMovie.Description = movie.Description;
                existingMovie.Year = movie.Year;
                existingMovie.Genre = movie.Genre;
                return existingMovie;
            }
            return null;
        }

        public void DeleteMovieById(int id)
        {
            var movie = StaticDb.Movies.FirstOrDefault(x => x.Id == id);
            if (movie != null)
            {
                StaticDb.Movies.Remove(movie);
            }
        }

        public void DeleteMovieByIdFromBody(int id)
        {
            DeleteMovieById(id);
        }
    }
}
