using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.WebAssembly.Services;
using System.Reflection;

namespace BlazorPeliculas.Client
{
    public partial class App
    {
        [Inject]
        private LazyAssemblyLoader LazyLoader { get; set; }
        private List<Assembly> AdditionalAssemblies { get; set; } = new();
        private async Task OnNavigateAsync(NavigationContext args)
        {
            if (args.Path.EndsWith("counter"))
            {
                var additionalAssemblies = await LazyLoader.LoadAssembliesAsync(new List<string>() { "MathNet.Numerics.dll" });
                AdditionalAssemblies.AddRange(additionalAssemblies);
            }
        }
    }
}
