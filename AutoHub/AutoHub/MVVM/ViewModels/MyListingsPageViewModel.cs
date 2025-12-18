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
        private ObservableCollection<ListingModel> _currentUserListings = [];

        [ObservableProperty]
        public partial bool IsLoading { get; set; }

        [ObservableProperty]
        public partial string? SearchQuery { get; set; }

        [ObservableProperty]
        public partial string? ErrorMessage { get; set; }

        partial void OnSearchQueryChanged(string? value)
        {
            LoadCarsCommand.Execute(null);
        }

        [RelayCommand]
        private async Task ShowMenuAsync(ListingModel listing)
        {
            if (listing == null) return;

            try
            {
                var action = await MainThread.InvokeOnMainThreadAsync(async () =>
                {
                    return await Shell.Current.DisplayActionSheet(
                        "Choose an action",
                        "Cancel",
                        null,
                        "Edit",
                        "Delete"
                    );
                });

                if (action == "Edit")
                {
                    await GoToEditAsync(listing);
                }
                else if (action == "Delete")
                {
                    var confirm = await MainThread.InvokeOnMainThreadAsync(async () =>
                    {
                        return await Shell.Current.DisplayAlert(
                            "Delete Listing",
                            "Are you sure you want to delete this listing?",
                            "Delete",
                            "Cancel"
                        );
                    });

                    if (confirm)
                    {
                        await DeleteListingAsync(listing);
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = $"Error: {ex.Message}";
            }
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
                ErrorMessage = string.Empty;

                var carList = await listingRepository.GetListingsByUserIdAsync(userId, SearchQuery);

                if (carList == null)
                {
                    carList = new List<ListingModel>();
                }

                CurrentUserListings.Clear();
                foreach (var listing in carList)
                {
                    if (listing != null)
                    {
                        CurrentUserListings.Add(listing);
                    }
                }
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

        
    }
}

