using MovieStore.Models.DTO;

namespace MovieStore.Models.Views
{
    public class MovieView
    {
        public int MovieId { get; set; }

        public string MovieTitle { get; set; } = string.Empty;

        public int MovieYear { get; set; }

        public IEnumerable<Actor> Actors { get; set; } = [];
    }
}
