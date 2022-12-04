using Microsoft.AspNetCore.Components;

namespace BlazorPeliculas.Client.Pages.Movie
{
    public partial class CreateMovie
    {
        [Inject]
        private NavigationManager NavigationManager { get; set; }
        public void CreateNewMovie()
        {
            Console.WriteLine(NavigationManager.Uri);
            NavigationManager.NavigateTo("movie");
        }
    }
}
