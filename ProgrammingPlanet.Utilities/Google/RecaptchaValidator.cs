using Newtonsoft.Json;

namespace ProgrammingPlanet.Utilities.Google;

public static class RecaptchaValidator
{
    private const string recaptchaSecret = "6LcqpHYlAAAAANP64HTvCP0Aiftocy5_uId7remU";
    public static async Task<bool> IsValidRecaptchaCodeAsync(this string code)
    {
        using (HttpClient client = new())
        {
            var message = await client.PostAsync(
                $"https://www.google.com/recaptcha/api/siteverify?secret={recaptchaSecret}&response={code}",
                null!
                );
            var result = JsonConvert.DeserializeObject<RecaptchaValidationResult>(await message.Content.ReadAsStringAsync());
            return result.success;
        }
    }
}
