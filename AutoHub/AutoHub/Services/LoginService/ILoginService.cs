using AutoHub.MVVM.Models;

namespace AutoHub.Services.LoginService
{
    public interface ILoginService
    {
        Task<UserModel> LoginAsync(string email, string password);
    }
}
