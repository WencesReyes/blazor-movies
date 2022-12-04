using Microsoft.AspNetCore.Components;

namespace BlazorPeliculas.Client.Pages.Movie
{
    public partial class EditMovie
    {
        [Parameter]
        public int Id { get; set; }

        protected override void OnInitialized()
        {
            Console.WriteLine(Id);   
        }
    }
}
