namespace BlazorEcommerceNEW.Services.AuthService
{
    public interface IServerAuthService
    {
        Task<ServiceResponse<int>> Register(User user, string password);
        Task<bool> UserExists(string email);
        Task<ServiceResponse<string>> Login(string email, string password);
    }
}
