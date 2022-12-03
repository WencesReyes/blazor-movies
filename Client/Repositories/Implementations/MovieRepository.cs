using BlazorPeliculas.Shared.Entities;

namespace BlazorPeliculas.Client.Repositories.Implementations
{
    public class MovieRepository : IMovieRepository
    {
        public IEnumerable<MovieEntity> GetAll()
        {
            return new List<MovieEntity>(){
            new MovieEntity
            {
                Title = "Moana",
                LaunchDate = new DateTime(2012, 8, 1)
            },
            new MovieEntity
            {
                Title = "Spide-Man",
                LaunchDate = new DateTime(2019, 9, 27)
            },
            new MovieEntity
            {
                Title = "Titanic",
                LaunchDate = new DateTime(2015, 12, 10)
            }};
        }
    }
}
