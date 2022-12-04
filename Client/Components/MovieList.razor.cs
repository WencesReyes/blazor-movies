using BlazorPeliculas.Client.Helpers;
using BlazorPeliculas.Shared.Entities;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorPeliculas.Client.Components
{
    public partial class MovieList
    {
        [Inject]
        private IJSRuntime Js { get; set; }
        [Parameter]
        public List<MovieEntity> Movies { get; set; }

        private bool ShowButtons { get; set; } = false;

        private async Task DeleteMovie(MovieEntity movie)
        {
            var confirmed = await Js.Confirm($"Are you sure to delete movie: {movie.Title}?");
            if (confirmed)
            {
                Movies.Remove(movie);
                Console.WriteLine($"Movie {movie.Title} was deleted!");
            }
        }

        protected override void OnInitialized()
        {
            Console.WriteLine($"OnInitialized - Movies count: {Movies.Count}");
        }

        protected override void OnParametersSet()
        {
            Console.WriteLine($"OnParametersSet - Movies count: {Movies.Count}");
        }

        protected override bool ShouldRender()
        {
            Console.WriteLine("ShouldRender");
            return true;
        }

        protected override void OnAfterRender(bool firstRender)
        {
            Console.WriteLine($"OnAfterRender {firstRender}");
        }

        public void CleanMovies() 
        {
            if (Movies is not null)
                Movies.Clear();
        }
    }
}
