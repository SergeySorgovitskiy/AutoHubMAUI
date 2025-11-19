using AutoHub.MVVM.Models;

namespace AutoHub.Services.Repositories.ListingRepository
{
    public interface IListingRepository
    {
        Task<List<CarListingModel>> GetListingsAsync();
        Task<CarListingModel> GetDetailsByIdAsync(int carId);

    }

}
