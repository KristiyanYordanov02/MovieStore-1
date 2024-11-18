
using Mapster;
using MovieStore.Controllers;
using MovieStore.Models.DTO;
using MovieStore.Models.Request;

namespace MovieStore.MasterConfig
{
    public static class MapsterConfiguration
    {
        public static void Configure()
        {
            TypeAdapterConfig<Movie, AddMovieRequest>
           .NewConfig()
        .TwoWays();
        }


    
    }
}
