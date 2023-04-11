namespace ProgrammingPlanet.ContactService.DAL.Database;

public class ContactDataContext : DbContext
{
	public ContactDataContext(DbContextOptions<ContactDataContext> options ) : base( options )
	{

	}

	public DbSet<Contact> Contacts => Set<Contact>();
	public DbSet<ContactAnswere> ContactAnsweres => Set<ContactAnswere>();
}
