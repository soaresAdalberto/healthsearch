using HealthSearch;
using HealthSearch.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<HealthSearchIndexService>();
builder.Services.AddScoped<PdfExtractionService>();
builder.Services.AddScoped<BooleanSearchService>();
builder.Services.AddScoped<VectorSearchService>();
builder.Services.AddScoped<EvaluationService>();

await builder.Build().RunAsync();
