using BlazorPeliculas.Client.Helpers;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Microsoft.JSInterop.Implementation;

namespace BlazorPeliculas.Client.Pages
{
    public partial class Counter
    {
        private int CurrentCount = 0;
        private static int CurrentCountStatic = 0;
        [Inject]
        private IJSRuntime Js { get; set; }
        private IJSObjectReference? CounterModule;
        [CascadingParameter]
        public AppState GlobalState { get; set; }

        [JSInvokable]
        public async Task IncrementCount()
        {
            CounterModule = await Js.InvokeAsync<IJSObjectReference>("import", "./js/counter.js");
            await CounterModule.InvokeVoidAsync("ShowAlert", "Hello from js module");
            CurrentCount++;
            CurrentCountStatic++;
            await Js.InvokeVoidAsync("TestGetCurrentStaticValue");
        }

        public async Task IncrementCountJs()
        {
            await Js.InvokeVoidAsync("TestGetCurrentValueFromInstance", DotNetObjectReference.Create(this));
        }

        [JSInvokable]
        public static Task<int> GetCurrentCount()
            => Task.FromResult(CurrentCountStatic);
    }
}
