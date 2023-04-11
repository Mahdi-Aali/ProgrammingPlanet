using Microsoft.Extensions.DependencyInjection;

namespace ProgrammingPlanet.ContactService.DAL.Database;

public class ContactSeedData
{
    public static void InitialDatabase(IServiceProvider service)
    {
        InitialDatabaseAsync(service.CreateAsyncScope().ServiceProvider).Wait();
    }

    private static async Task InitialDatabaseAsync(IServiceProvider service)
    {
        var context = service.GetRequiredService<ContactDataContext>();

        if ((await context.Database.GetPendingMigrationsAsync()).Any())
        {
            await context.Database.MigrateAsync();
        }
    }
}
