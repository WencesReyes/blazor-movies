using BlazorPeliculas.Client.Repositories;
using BlazorPeliculas.Client.Repositories.Implementations;

namespace BlazorPeliculas.Client
{
    public static class AppServices
    {
        public static void AddServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IMovieRepository, MovieRepository>();
        }
    }
}
