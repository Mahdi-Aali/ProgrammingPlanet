namespace ProgrammingPlanet.BLL.Services.ContactUsServices;

public class WebContactUsServices : IWebContactUsServices
{
    private readonly IWebContactUsRepository _repository;

    public WebContactUsServices(IWebContactUsRepository repository) => _repository = repository;

    public async Task<bool> CreateContactUsAsync(CreateContactUsModel model) =>
        await _repository.CreateContactUsAsync(model);
}
