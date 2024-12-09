using MovieStore.Models.DTO;

namespace MovieStore.BL.Interfaces
{
    public interface IMovieService
    {
        List<Movie> GetAllMovies();

        void AddMovie(Movie movie);

        Movie? GetById(int id);
    }
}
