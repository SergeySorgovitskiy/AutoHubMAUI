using AutoHub.MVVM.Models;
using AutoHub.Services.LoginService;
using AutoHub.Services.NavigationService;
using AutoHub.Services.Repositories.ListingRepository;
using AutoHub.Services.Repositories.UserRepository;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Linq;

namespace AutoHub.MVVM.ViewModels
{
    public partial class FavoritePageViewModel(
        IUserRepository userRepository,
        IListingRepository listingService,
        INavigationService navigationService, 
        ILoginService loginService) : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<ListingModel> _favoriteCars = new();

        private List<ListingModel> _allFavoriteCars = [];

        [ObservableProperty]
        public partial bool IsLoading { get; set; }

        [ObservableProperty]
        public partial string? SearchQuery { get; set; }

        [ObservableProperty]
        public partial string? ErrorMessage { get; set; }

        partial void OnSearchQueryChanged(string? value)
        {
            FilterCars();
        }

        [RelayCommand]
        private async Task GoToDetailsAsync(ListingModel car)
        {
            if (car == null) return;
            await navigationService.GoToDetailsAsync(car.Id);
        }

        [RelayCommand]
        private async Task LoadCarsAsync()
        {
            var currentUser = loginService.CurrentUser;
            if (currentUser == null) return;
            
            int userId = currentUser.Id;

            try
            {
                IsLoading = true;

                var carList = await listingService.GetFavoritesByUserIdAsync(userId);

                foreach (var car in carList)
                {
                    car.IsFavorite = true;
                }

                _allFavoriteCars = carList;
                FilterCars();
            }
            catch (Exception ex)
            {
                ErrorMessage = $"Failed to load favorites: {ex.Message}";
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

            var currentUser = loginService.CurrentUser;
            if (currentUser == null) return;

            var userId = currentUser.Id;
            await userRepository.ToggleFavoriteAsync(userId, car.Id);

            car.IsFavorite = false;

            if (FavoriteCars.Contains(car))
            {
                FavoriteCars.Remove(car);
                _allFavoriteCars.Remove(car);
            }
        }

        private void FilterCars()
        {
            if (string.IsNullOrWhiteSpace(SearchQuery))
            {
                FavoriteCars.Clear();
                foreach (var car in _allFavoriteCars)
                {
                    FavoriteCars.Add(car);
                }
                return;
            }

            var query = SearchQuery.ToLowerInvariant();
            var filtered = _allFavoriteCars.Where(car =>
                (car.Title?.ToLowerInvariant().Contains(query) ?? false) ||
                (car.Subtitle?.ToLowerInvariant().Contains(query) ?? false) ||
                (car.Description?.ToLowerInvariant().Contains(query) ?? false) ||
                (car.Location?.ToLowerInvariant().Contains(query) ?? false) ||
                car.Year.ToString().Contains(query) ||
                car.Price.ToString().Contains(query) ||
                car.Mileage.ToString().Contains(query) ||
                (car.IsElectric ? "electric" : "gas").Contains(query)
            ).ToList();

            FavoriteCars.Clear();
            foreach (var car in filtered)
            {
                FavoriteCars.Add(car);
            }
        }
    }
}