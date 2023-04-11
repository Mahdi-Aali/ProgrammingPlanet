namespace ProgrammingPlanet.ContactService.gRPC.Services;

public class WebContactService : WebContactServiceBase
{
    private readonly IWebContactService _service;

	public WebContactService(IWebContactService service) => _service = service;

    public override async Task<CreateContactReply> AddContact(CreateContactRequest request, ServerCallContext context) =>
        new CreateContactReply()
        {
            Id = await _service.AddContact(new CreateContactModel()
            {
                Name = request.Name,
                Email = request.Email,
                Subject = request.Subject,
                Message = request.Message
            })
        };
}
