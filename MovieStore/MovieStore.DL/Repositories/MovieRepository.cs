using MovieStore.DL.Interfaces;
using MovieStore.DL.StaticDB;
using MovieStore.Models.DTO;

namespace MovieStore.DL.Repositories
{
    internal class MovieRepository : IMovieRepository
    {
        public List<Movie> GetAllMovies()
        {
            return InMemoryDb.Movies;
        }

        public void AddMovie(Movie movie)
        {
            InMemoryDb.Movies.Add(movie);
        }

        /// <summary>
        /// Get movie by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Movie? GetMovieById(int id)
        {
           return InMemoryDb.Movies
               .FirstOrDefault(m => m.Id == id);
        }
    }
}
