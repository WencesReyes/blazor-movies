using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorPeliculas.Client.Pages
{
    public partial class Counter
    {
        private int currentCount = 0;
        private static int currentCountStatic = 0;
        [Inject]
        private IJSRuntime Js { get; set; } 


        private async Task IncrementCount()
        {
            currentCount++;
            currentCountStatic++;
            await Js.InvokeVoidAsync("TestGetCurrentStaticValue");
        }

        [JSInvokable]
        public static Task<int> GetCurrentCount()
            => Task.FromResult(currentCountStatic);
    }
}
