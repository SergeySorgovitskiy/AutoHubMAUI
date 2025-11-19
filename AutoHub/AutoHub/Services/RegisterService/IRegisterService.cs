using AutoHub.MVVM.Models;

namespace AutoHub.Services.RegisterService
{
    public interface IRegisterService
    {
        Task<bool> RegisterAsync(UserModel newUser);
    }
}
