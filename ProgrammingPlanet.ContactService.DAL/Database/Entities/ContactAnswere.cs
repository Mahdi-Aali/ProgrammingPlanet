namespace ProgrammingPlanet.ContactService.DAL.Database.Entities;

public partial class ContactAnswere
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string AnswereText { get; set; } = string.Empty;

    [Required]
    public DateTime CreateDate { get; set; }

    [Required]
    public int ContactId { get; set; }
    public Contact Contact { get; set; } = null!;
}
