using static ProgrammingPlanet.ContactService.gRPC.Protos.WebContactService;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
var configuration = builder.Configuration;

services.AddGrpcClient<WebContactServiceClient>(opt =>
{
    opt.Address = new Uri(configuration.GetSection("ContactService").Value.ToString());
}).ConfigureChannel(options =>
{
    options.CompressionProviders = new List<ICompressionProvider>()
    {
        new BrotliCompressionProvider(CompressionLevel.Optimal)
    };
});

services.AddRazorPages();

services.AddScoped<IWebContactUsRepository, WebContactUsRepository>();
services.AddScoped<IWebContactUsServices, WebContactUsServices>();

var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

app.UseStaticFiles();

app.UseRouting();

app.MapRazorPages();

app.Run();