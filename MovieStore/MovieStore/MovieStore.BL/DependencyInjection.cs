using Microsoft.Extensions.DependencyInjection;
using MovieStore.BL.Interfaces;
using MovieStore.BL.Services;
using MovieStore.DL;

namespace MovieStore.BL
{
    public static class DependencyInjection
    {
        public static IServiceCollection RegisterBusinessLayer(this IServiceCollection services)
        {
            services.AddSingleton<IMovieService, MovieService>();
            services.AddSingleton<IMovieBlService, MovieBlService>();

            return services;
        }

        public static IServiceCollection RegisterDataLayer(this IServiceCollection services)
        {
            services.RegisterRepositories();

            return services;
        }
    }
}
