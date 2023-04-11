namespace ProgrammingPlanet.Web.Filters;

public class ServiceNotAvailableExceptionAttribute : Attribute, IAsyncExceptionFilter
{
    private string _serviceName;

    public ServiceNotAvailableExceptionAttribute(string serviceName) => _serviceName = serviceName;

    public async Task OnExceptionAsync(ExceptionContext context)
    {
        if (context.Exception is RpcException ex)
        {
            context.Result = new ViewResult()
            {
                ViewName = "/Pages/Shared/Errors.cshtml",
                ViewData = new ViewDataDictionary(new EmptyModelMetadataProvider(), new ModelStateDictionary())
                {
                    Model = @$"The {_serviceName} service you requested for is not available right now. Please try again later!"
                }
            };
        }
        await Task.CompletedTask;
    }
}
