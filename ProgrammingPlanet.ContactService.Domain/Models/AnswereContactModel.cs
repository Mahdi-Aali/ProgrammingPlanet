namespace ProgrammingPlanet.ContactService.Domain.Models;

public record AnswereContactModel
{
    public int ContactId { get; init; }
    public string AnswereText { get; init; } = string.Empty;
}
