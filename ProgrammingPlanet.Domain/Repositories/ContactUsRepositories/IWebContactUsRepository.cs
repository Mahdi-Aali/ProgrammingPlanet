namespace ProgrammingPlanet.Domain.Repositories.ContactUsRepositories;

public interface IWebContactUsRepository
{
    public Task<bool> CreateContactUsAsync(CreateContactUsModel model);
}
