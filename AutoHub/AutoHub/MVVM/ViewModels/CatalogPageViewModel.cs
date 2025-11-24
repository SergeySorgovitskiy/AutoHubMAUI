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
    public partial class CatalogPageViewModel : ObservableObject
    {
        private readonly IListingRepository _listingRepository;
        private readonly IUserRepository _userRepository;
        private readonly INavigationService _navigationService;
        private readonly ILoginService _loginService;
        private readonly ILogger<CatalogPageViewModel> _logger;

        [ObservableProperty]
        private List<ListingModel> _cars = [];

        [ObservableProperty]
        private bool _isLoading;

        [ObservableProperty]
        private string? _searchQuery;

        public CatalogPageViewModel(ILoginService loginService,IUserRepository userRepository, IListingRepository listingRepository, INavigationService navigationService, ILogger<CatalogPageViewModel> logger)
        {
            _loginService = loginService;
            _listingRepository = listingRepository;
            _navigationService = navigationService;
            _userRepository = userRepository;
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
            IsLoading = true;
            try
            {
                var list = await _listingRepository.GetListingsAsync();
                var currentUser = _loginService.CurrentUser;

                foreach (var car in list)
                {
                    if (currentUser != null && currentUser.FavoriteCarIds.Contains(car.Id))
                    {
                        car.IsFavorite = true;
                    }
                    else
                    {
                        car.IsFavorite = false;
                    }
                }

                Cars = new List<ListingModel>(list);
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

            car.IsFavorite = !car.IsFavorite;

            var userId = _loginService.CurrentUser.Id;
            await _userRepository.ToggleFavoriteAsync(userId, car.Id);
        }
    }
}