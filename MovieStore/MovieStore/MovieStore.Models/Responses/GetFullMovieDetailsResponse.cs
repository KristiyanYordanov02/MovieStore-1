using MovieStore.Models.Views;

namespace MovieStore.Models.Responses
{
    public class GetFullMovieDetailsResponse
    {
        IEnumerable<MovieView> Movies { get; set; } = [];
    }
}
