using MovieStore.BL.Interfaces;
using MovieStore.DL.Interfaces;
using MovieStore.Models.DTO;
using MovieStore.Models.Views;

namespace MovieStore.BL.Services
{
    internal class MovieBlService : IMovieBlService
    {
        private readonly IMovieService _movieService;
        private readonly IActorRepository _actorRepository;

        public MovieBlService(
            IMovieService movieService,
            IActorRepository actorRepository)
        {
            _movieService = movieService;
            _actorRepository = actorRepository;
        }

        public List<MovieView> GetDetailedMovies()
        {
            var result = new List<MovieView>();

            var movies = _movieService.GetAllMovies();

            foreach (var movie in movies)
            {
                var actors = new List<Actor>(movie.Actors.Count());

                var movieView = new MovieView
                {
                    MovieId = movie.Id,
                    MovieTitle = movie.Title,
                    MovieYear = movie.Year,
                    Actors = _actorRepository.GetActorsByIds(movie.Actors)
                };

                actors.AddRange(movie.Actors.Select(id => _actorRepository.GetById(id)));
                movieView.Actors = actors;

                result.Add(movieView);
            }

            return result;
        }
    }
}