using AutoHub.MVVM.Models;
using AutoHub.Services.DbService;
using SQLite;

namespace AutoHub.Services.Repositories.ListingRepository
{
    public class ListingRepository(IDbService dbService) : IListingRepository
    {
        private SQLiteAsyncConnection Connection => dbService.GetConnection();
        public async Task<List<ListingModel>> GetListingsAsync()
        {
            return await Connection.Table<ListingModel>()
                .OrderByDescending(l=> l.CreatedDate)
                .ToListAsync();
        }
        public async Task<ListingModel?> GetDetailsByIdAsync(int carId)
        {
            return await Connection.Table<ListingModel>()
                .Where(c=> c.Id == carId)
                .FirstOrDefaultAsync();
        }
        public async Task<List<ListingModel>> GetFavoritesByUserIdAsync(int userId)
        {
            var favorites = await Connection.Table<FavoriteModel>()
                .Where(f => f.UserId == userId)
                .ToListAsync();
            
            var favoriteIds = favorites.Select(f => f.ListingId).ToList();

            if (favoriteIds.Count == 0)
                return new List<ListingModel>();

            return await Connection.Table<ListingModel>()
               .Where(l => favoriteIds.Contains(l.Id))
               .ToListAsync();
        }

        public async Task AddListingAsync(ListingModel newListing)
        {
            await Connection.InsertAsync(newListing);
        }
        public async Task UpdateListingAsync(ListingModel listing)
        {
            listing.UpdatedDate = DateTime.Now;
            await Connection.UpdateAsync(listing);
        }
        public async Task DeleteListingAsync(int listingId)
        {
            await Connection.DeleteAsync<ListingModel>(listingId);  
        }
        public async Task<List<ListingModel>> GetListingsByUserIdAsync(int userId)
        {
            return await Connection.Table<ListingModel>()
                .Where(l => l.SellerUserId == userId)
                .OrderByDescending(l => l.CreatedDate)
                .ToListAsync();
        }

    }
} 