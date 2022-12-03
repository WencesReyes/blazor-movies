using Microsoft.JSInterop;

namespace BlazorPeliculas.Client.Helpers
{
    public static class IJSRuntimeExtensions
    {
        public static async Task<bool> Confirm(this IJSRuntime js, string message)
        {
            var confirmed = await js.InvokeAsync<bool>("confirm", message);
            return confirmed;
        }
    }
}
