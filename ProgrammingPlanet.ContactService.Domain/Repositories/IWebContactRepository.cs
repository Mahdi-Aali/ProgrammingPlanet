namespace ProgrammingPlanet.ContactService.Domain.Repositories;

public interface IWebContactRepository
{
    public Task<int> AddContact(CreateContactModel model);
}
