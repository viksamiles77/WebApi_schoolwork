using Qinshft.Movies.DataAccess;
using Qinshft.Movies.DataAccess.Interfaces;
using Qinshift.Movies.DomainModels;
using Qinshift.Movies.DomainModels.Enums;
using Qinshift.Movies.DTOs;
using Qinshift.Movies.Services.Helpers;

namespace Qinshift.Movies.Services.Implementation
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepo;
        public MovieService(IMovieRepository movieRepo)
        {
            _movieRepo = movieRepo;
        }
        public List<MovieDto> GetAllMovies()
        {
            var movies = _movieRepo.GetAll();
            var movieListDto = new List<MovieDto>();
            foreach (var movie in movies)
            {
                var movieDto = MovieMapper.ToMovieDto(movie);
                movieListDto.Add(movieDto);
            }
            return movieListDto;
        }

        public int AddNewMovie(MovieCreateDto movie)
        {
            Movie movieModel = new();
            if (movie != null)
            {
                movieModel = MovieMapper.ToMovie(movie);
                return _movieRepo.Add(movieModel);
            }
            return 0;
        }

        public MovieDto GetMovieById(int id)
        {
            var movie = _movieRepo.GetById(id);
            return MovieMapper.ToMovieDto(movie);
        }

        public List<MovieDto> FilterMoviesByGenre(string genre)
        {
            var movies = _movieRepo.GetAll();
            var movieList = new List<MovieDto>();
            if (!string.IsNullOrEmpty(genre))
            {
                movies = movies.Where(x => x.Genre.ToString().ToLower() == genre.ToLower());
            }
            foreach (var movie in movies)
            {
                var movieDto = MovieMapper.ToMovieDto(movie);
                movieList.Add(movieDto);
            }
            return movieList;
            //if (Enum.TryParse<GenreEnum>(genre, true, out var genreEnum))
            //{
            //    return StaticDb.Movies.Where(x => x.Genre == genreEnum).ToList();
            //}
            //return new List<Movie>();
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

        public int DeleteMovieById(int id)
        {
            var existingMovie = _movieRepo.GetById(id);
            if (existingMovie != null)
            {
                _movieRepo.Remove(existingMovie.Id);
            }
            return 1;
        }

        public void DeleteMovieByIdFromBody(int id)
        {
            DeleteMovieById(id);
        }
    }
}
