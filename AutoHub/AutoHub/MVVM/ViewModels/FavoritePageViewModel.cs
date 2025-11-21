using AutoHub.MVVM.Models;
using AutoHub.Services.LoginService;
using AutoHub.Services.NavigationService;
using AutoHub.Services.Repositories.ListingRepository;
using AutoHub.Services.Repositories.UserRepository;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.Logging;

namespace AutoHub.MVVM.ViewModels
{
    public partial class FavoritePageViewModel : ObservableObject
    {
        private readonly IListingRepository _listingService;
        private readonly INavigationService _navigationService;
        private readonly ILogger<CatalogPageViewModel> _logger;
        private readonly ILoginService _loginService;
        private readonly IUserRepository _userRepository;

        [ObservableProperty]
        private List<ListingModel> _favoriteCars = [];

        [ObservableProperty]
        private bool _isLoading;

        [ObservableProperty]
        private string? _searchQuery;

        public FavoritePageViewModel(IUserRepository userRepository, IListingRepository listingService, INavigationService navigationService, ILogger<CatalogPageViewModel> logger, ILoginService loginService)
        {
            _userRepository = userRepository;
            _listingService = listingService;
            _navigationService = navigationService;
            _loginService = loginService;
            _logger = logger;
        }

        [RelayCommand]
        private async Task GoToDetailsAsync(ListingModel car)
        {
            if (car == null) return;
            await _navigationService.GoToDetailsAsync(car.Id);
        }

        [RelayCommand]
        private async Task LoadCarsAsync()
        {
            int userId = _loginService.CurrentUser.Id;

            try
            {
                IsLoading = true;

                var carList = await _listingService.GetFavoritesByUserIdAsync(userId);

                foreach (var car in carList)
                {
                    car.IsFavorite = true;
                }

                FavoriteCars = carList;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to load car list.");
            }
            finally
            {
                IsLoading = false;
            }
        }

        [RelayCommand]
        private async Task ToggleFavoriteAsync(ListingModel car)
        {
            if (car == null) return;

            var userId = _loginService.CurrentUser.Id;
            await _userRepository.ToggleFavoriteAsync(userId, car.Id);

            car.IsFavorite = false;

            if (FavoriteCars.Contains(car))
            {
                await LoadCarsAsync();
            }
        }
    }
}