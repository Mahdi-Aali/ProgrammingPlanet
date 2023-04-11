namespace ProgrammingPlanet.ContactService.DAL.Database.Entities;

public partial class ContactAnswere
{
	public ContactAnswere()
	{

	}

	public ContactAnswere(int id, string answereText, DateTime? createDate, int contactId)
	{
		Id = id;
		AnswereText = answereText;
		CreateDate = createDate ?? DateTime.Now;
		ContactId = contactId;
	}

	public ContactAnswere(string answereText, int contactId) : this(0, answereText, null, contactId)
	{

	}
}
