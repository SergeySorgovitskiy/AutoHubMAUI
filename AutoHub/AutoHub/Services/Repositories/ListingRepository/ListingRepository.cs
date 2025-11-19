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
            
        public async Task<List<CarListingModel>> GetListingsAsync()
        {
            await Task.Delay(500);
            return _store.Cars;
        }
        public async Task<CarListingModel> GetDetailsByIdAsync(int carId)
        {
            await Task.Delay(500); 
            
            return _store.Cars.FirstOrDefault(c => c.Id == carId);
        }
    }
}