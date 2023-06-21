using System.Text.Json;

namespace ChatbotClient.HttpRepository
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly HttpClient _client;
        private readonly JsonSerializerOptions _options = 
            new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        //Create constructor
        public AuthenticationService(HttpClient client)
        {
            _client = client;
        }



    }
}
