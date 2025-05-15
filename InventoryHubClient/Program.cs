using System;
using System.Net.Http;
using System.Threading.Tasks;
using InventoryHubClient;
using InventoryHubClient.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
// or use: using InventoryHubClient.Pages; if App.razor is in the Pages folder

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddScoped<APIHandler>();
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress),
});

await builder.Build().RunAsync();
