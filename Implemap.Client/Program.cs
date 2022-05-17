using Implemap.Client.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

// Register app services
// -> Location
builder.Services.AddHttpClient<LocationService>();
builder.Services.AddSingleton<ILocationService, LocationService>();
// -> Mapbox
builder.Services.AddSingleton<IMapboxService, MapboxService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.Use(async (context, next) =>
{
    context.Response.Headers.Add("Content-Security-Policy", "base-uri 'self'; " +
        "connect - src 'self' ws: https://*; " +
        "default - src 'self'; " +
        "img - src data: https:; " +
        "object-src 'none'; " +
        "script - src 'self' 'sha256-v8v3RKRPmN4odZ1CWM5gw80QKPCCWMcpNeOmimNL2AA=' 'unsafe-eval' https://api.mapbox.com/mapbox-gl-js/v2.8.1/mapbox-gl.js https://api.mapbox.com/mapbox-gl-js/plugins/mapbox-gl-geocoder/v5.0.0/mapbox-gl-geocoder.min.js;" +
        "style - src 'self' https://api.mapbox.com/mapbox-gl-js/v2.8.1/mapbox-gl.css " +
        "https://api.mapbox.com/mapbox-gl-js/plugins/mapbox-gl-geocoder/v5.0.0/mapbox-gl-geocoder.css; " +
        "upgrade - insecure - requests;" +
        "worker - src 'self' blob:; ");
    await next();
});

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();