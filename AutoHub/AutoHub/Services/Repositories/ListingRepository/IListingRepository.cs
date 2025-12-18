using AutoHub.MVVM.Models;

namespace AutoHub.Services.Repositories.ListingRepository
{
    public interface IListingRepository
    {
        Task<List<ListingModel>> GetListingsAsync(string? searchQuery = null);
        Task<ListingModel?> GetDetailsByIdAsync(int carId);
        Task<List<ListingModel>> GetFavoritesByUserIdAsync(int userId, string? searchQuery = null);
        Task AddListingAsync(ListingModel listing);
        Task UpdateListingAsync(ListingModel listing);
        Task DeleteListingAsync(int listingId);
        Task<List<ListingModel>> GetListingsByUserIdAsync(int userId, string? searchQuery = null);
    }
}