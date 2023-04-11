namespace ProgrammingPlanet.ContactService.DAL.Database.Entities;

public partial class Contact
{
    [Key]
    public int Id { get; set; }
    [Required]
    [MaxLength(50)]
    public string Name { get; set; } = string.Empty;
    [Required]
    [MaxLength(150)]
    public string Email { get; set; } = string.Empty;

    [Required]
    [MaxLength(80)]
    public string Subject { get; set; } = string.Empty;

    [Required]
    [MaxLength(800)]
    public string Message { get; set; } = string.Empty;

    [Required]
    public DateTime CreateDate { get; set; }

    [Required]
    public bool HasAnswere { get; set; } = false;

    [Required]
    public bool Seen { get; set; } = false;
}
