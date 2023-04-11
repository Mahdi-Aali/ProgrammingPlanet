using static ProgrammingPlanet.ContactService.gRPC.Protos.WebContactService;

namespace ProgrammingPlanet.DAL.Repositories.ContactUsRepositories;

public class WebContactUsRepository : IWebContactUsRepository
{
    private readonly WebContactServiceClient _client;

    public WebContactUsRepository(WebContactServiceClient client) => _client = client;

    public async Task<bool> CreateContactUsAsync(CreateContactUsModel model) => (await _client.AddContactAsync(new CreateContactRequest()
    {
        Name = model.Name,
        Subject = model.Subject,
        Email = model.Email,
        Message = model.Message
    })).Id > 0;
}