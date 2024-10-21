namespace AuthClient.App.Services.Contracts
{
    public interface IAuthService
    {
        Task<string> AuthenticateUserAsync(string username, string password);
    }
}
