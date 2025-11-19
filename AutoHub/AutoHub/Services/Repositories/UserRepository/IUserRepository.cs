using AutoHub.MVVM.Models;

namespace AutoHub.Services.Repositories.UserRepository
{
    public interface IUserRepository
    {
        Task<UserModel> GetUserAsync(string email, string password);
        Task<UserModel> GetUserByEmailAsync(string email);
        Task AddUserAsync(UserModel newUser);

    }
}
