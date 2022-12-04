using BlazorPeliculas.Shared.Entities;
using Microsoft.AspNetCore.Components;

namespace BlazorPeliculas.Client.Components
{
    public partial class Movie
    {
        [Parameter]
        public MovieEntity MovieItem { get; set; }
        [Parameter]
        public bool ShowButtons { get; set; } = false;
        [Parameter]
        public EventCallback<MovieEntity> DeleteMovie { get; set; }
        private string UrlMovie = string.Empty;
    }
}
