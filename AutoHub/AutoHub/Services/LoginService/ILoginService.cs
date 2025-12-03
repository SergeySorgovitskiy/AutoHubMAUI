using AutoHub.MVVM.Models;

namespace AutoHub.Services.LoginService
{
    public interface ILoginService
    {
        UserModel? CurrentUser { get; }
        Task<UserModel?> LoginAsync(string email, string password);
        Task LogoutAsync();
    }
}
