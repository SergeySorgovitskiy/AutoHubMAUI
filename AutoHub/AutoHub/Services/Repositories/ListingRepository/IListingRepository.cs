using AutoHub.MVVM.Models;

namespace AutoHub.Services.Repositories.ListingRepository
{
    public interface IListingRepository
    {
        Task<List<ListingModel>> GetListingsAsync();
        Task<ListingModel> GetDetailsByIdAsync(int carId);
        Task<List<ListingModel>> GetFavoritesByUserIdAsync(int userId);

    }

}
