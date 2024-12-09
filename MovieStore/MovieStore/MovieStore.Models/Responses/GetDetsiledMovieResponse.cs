using MovieStore.Models.DTO;

namespace MovieStore.Models.Responses
{
    public class GetDetailedMovieResponse
    {
        public Movie Movie { get; set; }

        public List<Actor> Actors { get; set; }
    }
}
