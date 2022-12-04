using Microsoft.AspNetCore.Components;

namespace BlazorPeliculas.Client.Pages.Actor
{
    public partial class EditActor
    {
        [Parameter]
        public int Id { get; set; }

        protected override void OnInitialized()
        {
            Console.WriteLine(Id);
        }
    }
}
