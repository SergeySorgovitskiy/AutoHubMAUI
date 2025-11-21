using AutoHub.MVVM.Models;
using AutoHub.Services.AppMemoryStore;

namespace AutoHub.Services.Repositories.UserRepository
{
    public class UserRepository : IUserRepository
    {
        private readonly Store _store;
        public UserRepository(Store store)
        {
            _store = store;
        }
        public Task<UserModel> GetUserAsync(string email, string password)
        {
            var user = _store.Users.FirstOrDefault(u => u.Email == email && u.Password == password);

            return Task.FromResult(user);
        }
        public Task<UserModel> GetUserByEmailAsync(string email)
        {
            var user = _store.Users.FirstOrDefault(u => u.Email == email);

            return Task.FromResult(user);
        }
        public Task AddUserAsync(UserModel newUser)
        {
            newUser.Id = _store.Users.Count + 1;
            _store.Users.Add(newUser);

            return Task.CompletedTask;
        }
        public Task ToggleFavoriteAsync(int userId, int listingId)
        {
            var user = _store.Users.FirstOrDefault(u => u.Id == userId);
            if (user == null)
            {
                return Task.CompletedTask;
            }

            if(user.FavoriteCarIds.Contains(listingId))
            {
                user.FavoriteCarIds.Remove(listingId);
            }
            else
            {
                user.FavoriteCarIds.Add(listingId);
            }
                
            return Task.CompletedTask;
        }
    }

}
