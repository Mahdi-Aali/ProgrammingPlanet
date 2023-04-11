namespace ProgrammingPlanet.Domain.Services.ContactUsServices;

public interface IWebContactUsServices
{
    public Task<bool> CreateContactUsAsync(CreateContactUsModel model);
}
