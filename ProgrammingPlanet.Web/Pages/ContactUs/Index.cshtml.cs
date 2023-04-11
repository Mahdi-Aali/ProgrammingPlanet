using ProgrammingPlanet.Utilities.Google;
using ProgrammingPlanet.Web.Filters;

namespace ProgrammingPlanet.Web.Pages.ContactUs;

[AutoValidateAntiforgeryToken]
[ServiceNotAvailableException("Contact Us")]
public class IndexModel : PageModel
{

    private readonly IWebContactUsServices _service;

    public IndexModel(IWebContactUsServices service) => _service = service;


    [BindProperty]
    [FromForm]
    public CreateContactUsModel ContactUs { get; set; } = null!;
    public void OnGet()
    {
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (await Request.Form["g-recaptcha-response"].ToString().IsValidRecaptchaCodeAsync()) 
        {
            if (ModelState.IsValid)
            {
                if (await _service.CreateContactUsAsync(ContactUs))
                {
                    return Redirect("/");
                }
                else
                {
                    ModelState.AddModelError("All", "Oooops Some thing bad happend on server. Please try again.");
                }
            }
        }
        else
        {
            ModelState.AddModelError("All", @"Please verify ""Im not robot"" ckeck box!");
        }
        
        return Page();
    }
}
