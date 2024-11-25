using MovieStore.Models.DTO;

namespace MovieStore.DL.Interfaces
{
    public interface IMovieRepository
    {
        List<Movie> GetAllMovies();
        void AddMovie(Movie movie);
        Movie? GetMovieId(int id);

        //void UpdateMovie(Movie movie);
        //void DeleteMovie(int id);
    }
}
