using AutoHub.MVVM.Models;
using AutoHub.Services.AppMemoryStore;

namespace AutoHub.Services.Repositories.ListingRepository
{
    public class ListingRepository : IListingRepository
    {
        private readonly Store _store;
        public ListingRepository(Store store)
        {
            _store = store;
        }
        public async Task<List<ListingModel>> GetListingsAsync()
        {
            await Task.Delay(500);

            return _store.Listings;
        }
        public async Task<ListingModel> GetDetailsByIdAsync(int carId)
        {
            await Task.Delay(500); 
            
            return _store.Listings.FirstOrDefault(c => c.Id == carId);
        }
        public Task<List<ListingModel>> GetFavoritesByUserIdAsync(int userId)
        {
            
            var user = _store.Users.FirstOrDefault(u => u.Id == userId);

            if (user == null || user.FavoriteCarIds == null || user.FavoriteCarIds.Count == 0)
            {
                return Task.FromResult(new List<ListingModel>());
            }

            var favoriteListings = _store.Listings
                .Where(car => user.FavoriteCarIds.Contains(car.Id))
                .ToList();

            return Task.FromResult(favoriteListings);
        }
    }
} 