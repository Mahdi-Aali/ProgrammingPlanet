using ProgrammingPlanet.ContactService.gRPC.Compression;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
var configuration = builder.Configuration;

services.AddGrpc(opt =>
{
    opt.ResponseCompressionAlgorithm = "br";
    opt.CompressionProviders = new List<ICompressionProvider>()
    {
        new BrotliCompressionProvider(CompressionLevel.Optimal)
    };
    opt.EnableDetailedErrors = true;
    opt.ResponseCompressionLevel = CompressionLevel.Optimal;
});

services.AddScoped<IWebContactRepository, EfWebContactRepository>();
services.AddScoped<IWebContactService, BLL::WebContactService>();
services.AddSingleton<ProtoExposeService>();

services.AddDbContext<ContactDataContext>(options =>
{
    options.UseSqlServer(configuration.GetConnectionString("default"), opt =>
    {
        opt.MigrationsAssembly("ProgrammingPlanet.ContactService.gRPC");
    });
});

var app = builder.Build();


app.MapGrpcService<Services::WebContactService>();
app.MapGet("/", () => "Hello World!");
app.MapGet("/Protos/GetAll/M@|-|d14@l!", ([FromServices] ProtoExposeService service) =>
{
    return Results.Ok(service.GetAll());
});
app.MapGet("/Protos/{name}/{version}/M@|-|d14@l!/view", async ([FromServices] ProtoExposeService service, string name, string version) =>
{
    return Results.Text(await service.ViewAsync(name, version));
});
app.MapGet("/Protos/M@|-|d14@l!/{version}/{name}", ([FromServices] ProtoExposeService service, string name, string version) =>
{
    return Results.File(service.Get(name, version));
});

ContactSeedData.InitialDatabase(app.Services);
app.Run();