namespace ProgrammingPlanet.ContactService.Domain.Models;

public record ContactModel
{
    public int Id { get; init; }
    public string Name { get; init; } = string.Empty;
    public string Email { get; init; } = string.Empty;
    public string Subject { get; init; } = string.Empty;
    public string Message { get; init; } = string.Empty;
    public DateTime CreateDate { get; init; }
    public bool HasAnswere { get; init; }
    public bool Seen { get; init; }
}
