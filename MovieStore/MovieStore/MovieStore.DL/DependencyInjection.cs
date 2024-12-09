using Microsoft.Extensions.DependencyInjection;
using MovieStore.DL.Interfaces;
using MovieStore.DL.Repositories;

namespace MovieStore.DL
{
    public static class DependencyInjection
    {
        public static void RegisterRepositories(this IServiceCollection services)
        {
            services
                .AddSingleton<IMovieRepository, MovieRepository>()
                .AddSingleton<IActorRepository, ActorStaticRepository>();
        }
    }
}
