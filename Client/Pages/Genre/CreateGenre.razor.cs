using BlazorPeliculas.Shared.Entities;

namespace BlazorPeliculas.Client.Pages.Genre
{
    public partial class CreateGenre
    {
        private GenreEntity Genre = new();

        public void Create()
        {
            Console.WriteLine($"Genre: {Genre.Description}");
        }
    }
}
