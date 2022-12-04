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
                LaunchDate = new DateTime(2012, 8, 1),
                Poster = "https://upload.wikimedia.org/wikipedia/en/2/26/Moana_Teaser_Poster.jpg",
            },
            new MovieEntity
            {
                Title = "Spide-Man",
                LaunchDate = new DateTime(2019, 9, 27),
                Poster = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/90/Spiderman.JPG/1024px-Spiderman.JPG",
            },
            new MovieEntity
            {
                Title = "Titanic",
                LaunchDate = new DateTime(2015, 12, 10),
                Poster = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fd/RMS_Titanic_3.jpg/220px-RMS_Titanic_3.jpg",
            }};
        }
    }
}
