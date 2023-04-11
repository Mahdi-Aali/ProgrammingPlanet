namespace ProgrammingPlanet.ContactService.gRPC.Services;

public class ProtoExposeService
{
    private readonly string rootPath;

    public ProtoExposeService(IWebHostEnvironment env) => rootPath = Path.Combine(env.ContentRootPath, "Protos");

    public IDictionary<string, IEnumerable<string>> GetAll()
    {
        return Directory.GetDirectories(rootPath).Select(d => new
        {
            Version = d,
            Protos = Directory.GetFiles(d).Select(Path.GetFileName)
        }).ToDictionary(o => Path.GetRelativePath("Protos", o.Version), o => o.Protos)!;
    }

    public async Task<string> ViewAsync(string name, string version)
    {
        string filePath = Path.Combine(rootPath, version, name);
        return File.Exists(filePath) ? await File.ReadAllTextAsync(filePath) : null!;
    }

    public string Get(string name, string version)
    {
        string filePath = Path.Combine(rootPath, version, name);
        return File.Exists(filePath) ? filePath : null!;
    }
}
