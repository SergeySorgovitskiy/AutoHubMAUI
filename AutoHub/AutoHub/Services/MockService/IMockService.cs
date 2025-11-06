using AutoHub.MVVM.Models;

namespace AutoHub.Services.MockService
{
    public interface IMockService
    {
        Task<List<CarListingModel>> GetListingsAsync();
    }
}
