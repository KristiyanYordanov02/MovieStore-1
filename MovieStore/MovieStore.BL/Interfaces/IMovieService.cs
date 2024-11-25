using MovieStore.Models.DTO;

namespace MovieStore.BL.Interfaces
{
    public interface IMovieService
    {
        List<Movie> GetAllMovies();

        void AddMovie(Movie movie);
        void deleteMovie(int id);
        void UpdateMovie(Movie movieDto);

        Movie GetById(int id);
    }
}
