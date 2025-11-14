using AutoHub.MVVM.Models;

namespace AutoHub.Services.DataService
{
    public interface IDataService
    {
        Task<List<CarListingModel>> GetListingsAsync();
        Task<CarListingModel> GetDetailsByIdAsync(int carId);
    }
}
