var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
var configuration = builder.Configuration;

services.AddRazorPages();
services.AddServerSideBlazor();

var app = builder.Build();



app.UseStaticFiles();

app.UseRouting();

app.MapRazorPages();
app.MapBlazorHub();

app.Run();
