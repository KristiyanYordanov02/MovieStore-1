using Mapster;
using MovieStore.Models.DTO;
using MovieStore.Models.Requests;

namespace MovieStore.MapsterConfig
{
    public class MapsterConfiguration
    {
        public static void Configure()
        {
            TypeAdapterConfig<Movie, AddMovieRequest>
                .NewConfig()
                .TwoWays();
        }
    }
}
