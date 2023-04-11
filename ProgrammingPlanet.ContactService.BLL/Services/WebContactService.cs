namespace ProgrammingPlanet.ContactService.BLL.Services;

public class WebContactService : IWebContactService
{
    private readonly IWebContactRepository _repository;

    public WebContactService(IWebContactRepository repository) => _repository = repository;

    public async Task<int> AddContact(CreateContactModel model) => await _repository.AddContact(model);
}
