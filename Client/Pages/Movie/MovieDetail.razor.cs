using Microsoft.AspNetCore.Components;

namespace BlazorPeliculas.Client.Pages.Movie
{
    public partial class MovieDetail
    {
        [Parameter]
        public int Id { get; set; }
        [Parameter]
        public string MovieTitle { get; set; }
        protected override void OnInitialized()
        {
            Console.WriteLine($"{Id} {MovieTitle}");
        }
    }
}
