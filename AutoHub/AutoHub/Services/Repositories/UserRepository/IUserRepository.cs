using AutoHub.MVVM.Models;

namespace AutoHub.Services.Repositories.UserRepository
{
    public interface IUserRepository
    {
        Task<UserModel?> GetUserAsync(string email, string password);
        Task<UserModel?> GetUserByEmailAsync(string email);
        Task<UserModel?> GetUserByIdAsync(int userId);
        Task AddUserAsync(UserModel newUser);
        Task UpdateUserAsync(UserModel user);
        Task ToggleFavoriteAsync(int userId, int listingId); 
        Task<List<int>> GetFavoriteIdsAsync(int userId);
    }
}
