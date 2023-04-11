namespace ProgrammingPlanet.Domain.Models.ContactUs;

public record CreateContactUsModel
{
    [Required(ErrorMessage = "Name can't be null")]
    [MaxLength(50, ErrorMessage = "You can't enter more than 50 character for name!")]
    [MinLength(3, ErrorMessage = "You can't enter less than 30 character for name!")]
    public string Name { get; init; } = string.Empty;

    [Required(ErrorMessage = "Email can't be null")]
    [MaxLength(150, ErrorMessage = "You can't enter more than 150 character for email!")]
    [MinLength(10, ErrorMessage = "You can't enter less than 10 character for email!")]
    [DataType(DataType.EmailAddress, ErrorMessage = "Please enter valid email address!")]
    [EmailAddress(ErrorMessage = "Please enter valid email address!")]
    public string Email { get; init; } = string.Empty;

    [Required(ErrorMessage = "Subject can't be null")]
    [MaxLength(80, ErrorMessage = "You can't enter more than 80 character for subject!")]
    [MinLength(5, ErrorMessage = "You can't enter more than 8 character for subject!")]
    public string Subject { get; init; } = string.Empty;

    [Required(ErrorMessage = "Message can't be null")]
    [MaxLength(800, ErrorMessage = "You can't enter more than 800 character for message!")]
    [MinLength(10, ErrorMessage = "You can't enter more than 10 character for message!")]
    public string Message { get; init; } = string.Empty;
}