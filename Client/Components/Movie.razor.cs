using BlazorPeliculas.Shared.Entities;
using Microsoft.AspNetCore.Components;

namespace BlazorPeliculas.Client.Components
{
    public partial class Movie
    {
        [Parameter]
        public MovieEntity Pelicula { get; set; }
        [Parameter]
        public bool ShowButtons { get; set; } = false;
        [Parameter]
        public EventCallback<MovieEntity> DeleteMovie { get; set; }
    }
}
