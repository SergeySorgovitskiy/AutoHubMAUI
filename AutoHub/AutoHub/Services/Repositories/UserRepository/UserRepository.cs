using AutoHub.MVVM.Models;
using AutoHub.Services.DbService;
using SQLite;

namespace AutoHub.Services.Repositories.UserRepository
{
    public class UserRepository(IDbService dbService) : IUserRepository
    {
        private SQLiteAsyncConnection Connection => dbService.GetConnection();

        public async Task<UserModel?> GetUserByIdAsync(int userId)
        {
            return await Connection.Table<UserModel>()
                .Where(u => u.Id == userId)
                .FirstOrDefaultAsync();
        }
        public async Task<UserModel?> GetUserAsync(string email, string password)
        {
            return await Connection.Table<UserModel>()
                .Where(u => u.Email == email && u.Password == password)
                .FirstOrDefaultAsync();
        }
        public async Task<UserModel?> GetUserByEmailAsync(string email)
        {
            return await Connection.Table<UserModel>()
                .Where(u => u.Email == email)
                .FirstOrDefaultAsync();
        }
        public async Task AddUserAsync(UserModel newUser)
        {
           await Connection.InsertAsync(newUser);
        }

        public async Task UpdateUserAsync(UserModel user)
        {
            await Connection.UpdateAsync(user);
        }
        public async Task ToggleFavoriteAsync(int userId, int listingId)
        {
            var existingFavorite = await Connection.Table<FavoriteModel>()
                .Where(f => f.UserId == userId && f.ListingId == listingId)
                .FirstOrDefaultAsync();

            if (existingFavorite != null)
            {
                await Connection.DeleteAsync(existingFavorite);
            }

            else
            {
                var newFavorite = new FavoriteModel
                {
                    UserId = userId,
                    ListingId = listingId,
                    AddedDate = DateTime.UtcNow
                };

                await Connection.InsertAsync(newFavorite);
            }
        }

        public async Task<List<int>> GetFavoriteIdsAsync(int userId)
        {
            var favorites = await Connection.Table<FavoriteModel>()
                .Where(f => f.UserId == userId)
                .ToListAsync();

            return favorites.Select(f => f.ListingId).ToList();
        }
    }

}
