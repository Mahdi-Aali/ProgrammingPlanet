namespace ProgrammingPlanet.ContactService.DAL.Repositories;

public class EfWebContactRepository : IWebContactRepository
{
    private readonly ContactDataContext _context;
    private readonly ILogger<EfWebContactRepository> _logger;

    public EfWebContactRepository(ContactDataContext context
        , ILogger<EfWebContactRepository> logger)
    {
        _context = context;
        _logger = logger;
    }

    public async Task<int> AddContact(CreateContactModel model)
    {
        var Contact = new Contact(model.Name, model.Subject, model.Email, model.Message);

        await _context.Contacts.AddAsync(Contact);
        await _context.SaveChangesAsync();

        _logger.LogInformation($"new contact with Id: {Contact.Id} created successfully.");
        return Contact.Id;
    }
}
