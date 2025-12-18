using AutoHub.MVVM.Models;
using AutoHub.Services.LoginService;
using AutoHub.Services.NavigationService;
using AutoHub.Services.Repositories.ListingRepository;
using AutoHub.Services.Repositories.UserRepository;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui.ApplicationModel;
using System.Collections.ObjectModel;
using Microsoft.Maui.Devices;

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
            _ = MainThread.InvokeOnMainThreadAsync(async () =>
            {
                await LoadCarsAsync();
            });
        }

        [RelayCommand]
        private async Task ShowMenuAsync(ListingModel listing)
        {
            if (listing == null) return;

            try
            {
                string? action = await Shell.Current.DisplayActionSheet(
                    "Choose an action",
                    "Cancel",
                    null,
                    "Edit",
                    "Delete"
                );

                if (action == "Edit")
                {
                    await GoToEditAsync(listing);
                }
                else if (action == "Delete")
                {
                    bool confirm = await Shell.Current.DisplayAlert(
                        "Delete Listing",
                        "Are you sure you want to delete this listing?",
                        "Delete",
                        "Cancel"
                    );

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
            if (IsLoading) return;

            var currentUser = loginService.CurrentUser;
            if (currentUser == null)
            {
                MainThread.BeginInvokeOnMainThread(() =>
                {
                    try
                    {
                        CurrentUserListings.Clear();
                    }
                    catch { }
                });
                return;
            }

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


                if (DeviceInfo.Platform == DevicePlatform.iOS)
                {
                    await Task.Delay(300);

                    MainThread.BeginInvokeOnMainThread(() =>
                    {
                        try
                        {
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
                            ErrorMessage = $"Error updating UI: {ex.Message}";
                        }
                        finally
                        {
                            IsLoading = false;
                        }
                    });
                }
                else
                {
                    await MainThread.InvokeOnMainThreadAsync(() =>
                    {
                        try
                        {
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
                            ErrorMessage = $"Error updating UI: {ex.Message}";
                        }
                    });
                    IsLoading = false;
                }
            }
            catch (Exception ex)
            {
                MainThread.BeginInvokeOnMainThread(() =>
                {
                    ErrorMessage = $"Failed to load listings: {ex.Message}";
                    IsLoading = false;
                });
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

                await MainThread.InvokeOnMainThreadAsync(() =>
                {
                    var itemToRemove = CurrentUserListings.FirstOrDefault(l => l.Id == listing.Id);
                    if (itemToRemove != null)
                    {
                        CurrentUserListings.Remove(itemToRemove);
                    }
                });
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



    }
}

