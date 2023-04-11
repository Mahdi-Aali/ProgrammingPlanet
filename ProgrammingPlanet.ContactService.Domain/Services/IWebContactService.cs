namespace ProgrammingPlanet.ContactService.Domain.Services;

public interface IWebContactService
{
    Task<int> AddContact(CreateContactModel model);
}
