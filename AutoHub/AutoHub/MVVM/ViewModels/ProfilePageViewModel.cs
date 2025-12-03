using AutoHub.MVVM.Models;
using AutoHub.MVVM.Views;
using AutoHub.Services.LoginService;
using AutoHub.Services.NavigationService;
using AutoHub.Services.Repositories.ListingRepository;
using AutoHub.Services.Repositories.UserRepository;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AutoHub.MVVM.ViewModels
{
    public partial class ProfilePageViewModel(
        ILoginService loginService,
        IUserRepository userRepository,
        IListingRepository listingRepository,
        INavigationService navigationService) : ObservableObject
    {
        [ObservableProperty]
        public partial UserModel? CurrentUser { get; set; }

        [ObservableProperty]
        public partial bool IsLoading { get; set; }

        [ObservableProperty]
        public partial string ErrorMessage { get; set; } = string.Empty;

        [ObservableProperty]
        public partial int ActiveListingsCount { get; set; }

        [ObservableProperty]
        public partial int FavoritesCount { get; set; }

        [ObservableProperty]
        public partial int SoldCount { get; set; }

        public bool HasErrorMessage => !string.IsNullOrEmpty(ErrorMessage);
        public string UserName => CurrentUser?.Name ?? "Unknown";
        public string UserEmail => CurrentUser?.Email ?? "";
        public string UserPhone => CurrentUser?.PhoneNumber ?? "";
        public string ProfileImageUrl => CurrentUser?.ProfileImageUrl ?? "default_profile_image.jpg";
        public string JoinedDateText => CurrentUser != null 
            ? $"Joined {CurrentUser.JoinedDate:dd.MM.yyyy}" 
            : "Joined Unknown";

        [RelayCommand]
        private async Task LoadUserDataAsync()
        {
            if (IsLoading) return;

            try
            {
                IsLoading = true;
                ErrorMessage = string.Empty;

                var user = loginService.CurrentUser;
                if (user == null)
                {
                    ErrorMessage = "User not logged in";
                    await navigationService.GoToLoginAsync();
                    return;
                }

                CurrentUser = await userRepository.GetUserByIdAsync(user.Id);
                
                if (CurrentUser == null)
                {
                    ErrorMessage = "Failed to load user data";
                    return;
                }

                await LoadStatisticsAsync();

                OnPropertyChanged(nameof(UserName));
                OnPropertyChanged(nameof(UserEmail));
                OnPropertyChanged(nameof(UserPhone));
                OnPropertyChanged(nameof(ProfileImageUrl));
                OnPropertyChanged(nameof(JoinedDateText));
            }
            catch (Exception ex)
            {
                ErrorMessage = $"Failed to load profile: {ex.Message}";
            }
            finally
            {
                IsLoading = false;
            }
        }

        private async Task LoadStatisticsAsync()
        {
            if (CurrentUser == null) return;

            try
            {
                var activeListings = await listingRepository.GetListingsByUserIdAsync(CurrentUser.Id);
                ActiveListingsCount = activeListings.Count;

                var favorites = await listingRepository.GetFavoritesByUserIdAsync(CurrentUser.Id);
                FavoritesCount = favorites.Count;

                SoldCount = 0;
            }
            catch (Exception ex)
            {
                ErrorMessage = $"Failed to load statistics: {ex.Message}";
            }
        }

        [RelayCommand]
        private async Task GoToFavoritesAsync()
        {
            await Shell.Current.GoToAsync($"//{nameof(FavoritePage)}");
        }

        [RelayCommand]
        private async Task GoToMyListingsAsync()
        {
            var user = loginService.CurrentUser;
            if (user != null)
            {
                await navigationService.GoToMyListingsAsync(user.Id);
            }
        }

        [RelayCommand]
        private async Task GoToAddListingAsync()
        {
            await Shell.Current.GoToAsync(nameof(AddListingPage));
        }

        [RelayCommand]
        private async Task EditProfileAsync()
        {
            await Shell.Current.GoToAsync(nameof(EditProfilePage));
        }

        [RelayCommand]
        private async Task LogoutAsync()
        {
            try
            {
                await loginService.LogoutAsync();
                await navigationService.GoToLoginAsync();
            }
            catch (Exception ex)
            {
                ErrorMessage = $"Failed to logout: {ex.Message}";
            }
        }

        public void OnAppearing()
        {
            LoadUserDataCommand.Execute(null);
        }
    }
}
