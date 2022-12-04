using Microsoft.AspNetCore.Components;

namespace BlazorPeliculas.Client.Pages.Genre
{
    public partial class EditGenre
    {
        [Parameter]
        public int Id { get; set; }

        protected override void OnInitialized()
        {
            Console.WriteLine(Id);
        }
    }
}
