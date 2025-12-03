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
    public partial class MyListingsPageViewModel(
        INavigationService navigationService,                                            
        ILoginService loginService,                                              
        IListingRepository listingRepository,                                         
        IUserRepository userRepository) : ObservableObject
    {

        [ObservableProperty]
        private ObservableCollection<ListingModel> _currentUserListings = new();

        [ObservableProperty]
        public partial bool IsLoading { get; set; }

        [ObservableProperty]
        public partial string? SearchQuery { get; set; }

        [ObservableProperty]
        public partial string? ErrorMessage { get; set; }

        private List<ListingModel> _allUserListings = [];

        partial void OnSearchQueryChanged(string? value)
        {
            FilterListings();
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

                var carList = await listingRepository.GetListingsByUserIdAsync(userId);

                _allUserListings = carList;
                FilterListings();
            }
            catch (Exception ex)
            {
                ErrorMessage = $"Failed to load listings: {ex.Message}";
            }
            finally
            {
                IsLoading = false;
            }
        }

        [RelayCommand]
        private async Task GoToEditAsync(ListingModel listing)
        {
            if (listing == null) return;
            await navigationService.GoToEditAsync(listing.Id);
        }

        [RelayCommand]
        private async Task DeleteListingAsync(ListingModel listing)
        {
            if (listing == null) return;

            try
            {
                IsLoading = true;
                ErrorMessage = string.Empty;
                await listingRepository.DeleteListingAsync(listing.Id);

                var itemToRemove = CurrentUserListings.FirstOrDefault(l => l.Id == listing.Id);
                if (itemToRemove != null)
                {
                    CurrentUserListings.Remove(itemToRemove);
                }

                var itemToRemoveFromAll = _allUserListings.FirstOrDefault(l => l.Id == listing.Id);
                if (itemToRemoveFromAll != null)
                {
                    _allUserListings.Remove(itemToRemoveFromAll);
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = $"Failed to delete listing: {ex.Message}";
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
        }

        public void OnAppearing()
        {
            LoadCarsCommand.Execute(null);
        }

        private void FilterListings()
        {
            if (string.IsNullOrWhiteSpace(SearchQuery))
            {
                CurrentUserListings = new ObservableCollection<ListingModel>(_allUserListings);
                return;
            }

            var query = SearchQuery.ToLowerInvariant();
            var filtered = _allUserListings.Where(listing =>
                (listing.Title?.ToLowerInvariant().Contains(query) ?? false) ||
                (listing.Subtitle?.ToLowerInvariant().Contains(query) ?? false) ||
                (listing.Description?.ToLowerInvariant().Contains(query) ?? false) ||
                (listing.Location?.ToLowerInvariant().Contains(query) ?? false) ||
                listing.Year.ToString().Contains(query) ||
                listing.Price.ToString().Contains(query) ||
                listing.Mileage.ToString().Contains(query) ||
                (listing.IsElectric ? "electric" : "gas").Contains(query)
            ).ToList();

            CurrentUserListings.Clear();
            foreach (var listing in filtered)
            {
                CurrentUserListings.Add(listing);
            }
        }
    }
}

