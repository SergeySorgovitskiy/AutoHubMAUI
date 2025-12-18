
namespace AutoHub.Services.NavigationService
{
    public interface INavigationService
    {
        Task GoToLoginAsync();
        Task GoToRegisterAsync();
        Task GoToForgotPasswordAsync();
        Task GoToCatalogAsync();
        Task GoBackAsync();
        Task GoToDetailsAsync(int carId);
        Task GoToEditAsync(int carId);
        Task GoToMyListingsAsync(int userId);
        Task GoToLocationPickerAsync();
        Task GoToFavoritesAsync(int userId);
        Task GoToAddListingAsync();
        Task GoToProfileAsync();
        Task GoToEditProfileAsync();
    }
}
