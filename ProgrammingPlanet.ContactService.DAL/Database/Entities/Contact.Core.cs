namespace ProgrammingPlanet.ContactService.DAL.Database.Entities;

public partial class Contact
{
	public Contact()
	{

	}

	public Contact(int id, string name, string email, string subject, string message, DateTime? createDate, bool hasAnswere = false, bool seen = false)
	{
		Id = id;
		Name = name;
		Subject = subject;
		Email = email;
		Subject = subject;
		Message = message;
		CreateDate = createDate ?? DateTime.Now;
		HasAnswere = hasAnswere;
		Seen = seen;
	}

	public Contact(string name, string subject, string email, string message)
		: this(0, name, email, subject, message, null)
	{

	}
}
