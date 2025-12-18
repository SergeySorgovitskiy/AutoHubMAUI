using AutoHub.MVVM.Views;

namespace AutoHub.Services.NavigationService
{
    public class NavigationService : INavigationService
    {
        public Task GoToLoginAsync()
        {
            return Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }
        public Task GoToRegisterAsync()
        {
            return Shell.Current.GoToAsync(nameof(RegisterPage));
        }
        public Task GoToForgotPasswordAsync()
        {
            return Shell.Current.GoToAsync(nameof(RegisterPage));
        }
        public Task GoToCatalogAsync()
        {
            return Shell.Current.GoToAsync($"//{nameof(CatalogPage)}");
        }
        public Task GoBackAsync()
        {
            return Shell.Current.GoToAsync("..");
        }
        public Task GoToDetailsAsync(int carId)
        {
            return Shell.Current.GoToAsync($"{nameof(DetailsPage)}?Id={carId}");
        }
        public Task GoToEditAsync(int carId)
        {
            return Shell.Current.GoToAsync($"{nameof(EditPage)}?Id={carId}");
        }

        public Task GoToMyListingsAsync(int userId)
        {
            return Shell.Current.GoToAsync($"{nameof(MyListingsPage)}?Id={userId}");
        }
        public Task GoToLocationPickerAsync()
        {
            return Shell.Current.GoToAsync(nameof(LocationPickerPage));
        }

        public Task GoToFavoritesAsync(int userId)
        {
            return Shell.Current.GoToAsync($"{nameof(FavoritePage)}?Id={userId}");
        }

        public Task GoToAddListingAsync()
        {
            return Shell.Current.GoToAsync(nameof(AddListingPage));
        }

        public Task GoToProfileAsync()
        {
            return Shell.Current.GoToAsync($"//{nameof(ProfilePage)}");
        }

        public Task GoToEditProfileAsync()
        {
            return Shell.Current.GoToAsync(nameof(EditProfilePage));
        }
    }
}
