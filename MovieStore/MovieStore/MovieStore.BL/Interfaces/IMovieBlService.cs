using MovieStore.Models.Views;

namespace MovieStore.BL.Interfaces
{
    public interface IMovieBlService
    {
        List<MovieView> GetDetailedMovies();
    }
}
