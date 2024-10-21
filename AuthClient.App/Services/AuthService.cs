using AuthClient.App.Services.Contracts;
using System.Text.Json;

namespace AuthClient.App.Services
{
    public class AuthService : IAuthService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;
        public AuthService(IHttpClientFactory httpClientFactory, IConfiguration configuration)
        {
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;
        }
        public async Task<string> AuthenticateUserAsync(string username, string password)
        {
            var client = _httpClientFactory.CreateClient();
            var apiBaseUrl = _configuration["ApiBaseUrl"];

            var formContent = new FormUrlEncodedContent([
                new KeyValuePair<string, string>("username", username),
                new KeyValuePair<string, string>("password", password)
                ]);

            var response = await client.PostAsync($"{apiBaseUrl}/auth/login", formContent);

            if (response.IsSuccessStatusCode) { 
                var content = await response.Content.ReadAsStringAsync();
                var jsonDocument = JsonDocument.Parse(content);
                var token = jsonDocument.RootElement.GetProperty("token").GetString();
                return token;
            }

            return null;
        }
    }
}
