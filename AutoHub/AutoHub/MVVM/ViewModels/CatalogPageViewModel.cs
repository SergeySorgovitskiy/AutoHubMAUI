using AutoHub.MVVM.Models;
using AutoHub.Services.LoginService;
using AutoHub.Services.NavigationService;
using AutoHub.Services.Repositories.ListingRepository;
using AutoHub.Services.Repositories.UserRepository;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace AutoHub.MVVM.ViewModels
{
    public partial class CatalogPageViewModel(
        ILoginService loginService,
        IUserRepository userRepository,
        IListingRepository listingRepository,
        INavigationService navigationService) : ObservableObject
    {
        
        [ObservableProperty]
        private ObservableCollection<ListingModel> _cars = new();

        private List<ListingModel> _allCars = [];

        [ObservableProperty]
        public partial bool IsLoading { get; set; }

        [ObservableProperty]
        public partial string SearchQuery { get; set; } = string.Empty;

        partial void OnSearchQueryChanged(string value)
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
            IsLoading = true;
            try
            {
                var list = await listingRepository.GetListingsAsync();
                var currentUser = loginService.CurrentUser;

                if (currentUser != null)
                {
                    var favoriteIds = await userRepository.GetFavoriteIdsAsync(currentUser.Id);

                    foreach (var car in list)
                    {
                        car.IsFavorite = favoriteIds.Contains(car.Id);
                    }
                }
                else
                {
                    foreach (var car in list)
                    {
                        car.IsFavorite = false;
                    }
                }

                _allCars = new List<ListingModel>(list);
                FilterCars();
            }
            finally
            {
                IsLoading = false;
            }
        }

        private void FilterCars()
        {
            if (string.IsNullOrWhiteSpace(SearchQuery))
            {
                Cars.Clear();
                foreach (var car in _allCars)
                {
                    Cars.Add(car);
                }
                return;
            }

            var query = SearchQuery.ToLowerInvariant();
            var filtered = _allCars.Where(car =>
                (car.Title?.ToLowerInvariant().Contains(query) ?? false) ||
                (car.Subtitle?.ToLowerInvariant().Contains(query) ?? false) ||
                (car.Description?.ToLowerInvariant().Contains(query) ?? false) ||
                (car.Location?.ToLowerInvariant().Contains(query) ?? false) ||
                car.Year.ToString().Contains(query) ||
                car.Price.ToString().Contains(query) ||
                car.Mileage.ToString().Contains(query) ||
                (car.IsElectric ? "electric" : "gas").Contains(query)
            ).ToList();

            Cars.Clear();
            foreach (var car in filtered)
            {
                Cars.Add(car);
            }
        }

        [RelayCommand]
        private async Task ToggleFavoriteAsync(ListingModel car)
        {
            if (car == null) return;

            var currentUser = loginService.CurrentUser;
            if (currentUser == null) return;

            car.IsFavorite = !car.IsFavorite;

            var userId = currentUser.Id;
            await userRepository.ToggleFavoriteAsync(userId, car.Id);
        }
    }
}