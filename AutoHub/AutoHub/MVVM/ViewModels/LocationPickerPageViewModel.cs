using AutoHub.MVVM.Models;
using AutoHub.Services.LoginService;
using AutoHub.Services.NavigationService;
using AutoHub.Services.Repositories.UserRepository;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Devices.Sensors;
using Microsoft.Maui.Maps;

namespace AutoHub.MVVM.ViewModels
{
    public partial class LocationPickerPageViewModel(
        IUserRepository userRepository,
        ILoginService loginService,
        INavigationService navigationService) : ObservableObject
    {
        [ObservableProperty]
        private Location? _selectedLocation;

        [ObservableProperty]
        private string _locationAddress = string.Empty;

        [ObservableProperty]
        private bool _isLoading;

        [ObservableProperty]
        private string _errorMessage = string.Empty;

        [ObservableProperty]
        private MapSpan? _mapSpan;

        private UserModel? _currentUser;

        public bool HasErrorMessage => !string.IsNullOrEmpty(ErrorMessage);

        public async Task LoadUserLocationAsync()
        {
            try
            {
                IsLoading = true;
                var user = loginService.CurrentUser;
                if (user == null) return;

                _currentUser = await userRepository.GetUserByIdAsync(user.Id);

                if (_currentUser != null &&
                    _currentUser.Latitude.HasValue &&
                    _currentUser.Longitude.HasValue)
                {
                    SelectedLocation = new Location(
                        _currentUser.Latitude.Value,
                        _currentUser.Longitude.Value);
                    LocationAddress = _currentUser.LocationAddress ?? string.Empty;

                    MapSpan = MapSpan.FromCenterAndRadius(
                        SelectedLocation,
                        Distance.FromKilometers(5));
                }
                else
                {
                    
                    SelectedLocation = new Location(37.7749, -122.4194); // San Francisco
                    MapSpan = MapSpan.FromCenterAndRadius(
                        SelectedLocation,
                        Distance.FromKilometers(10));
                    LocationAddress = "Select location on map";
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = $"Failed to load location: {ex.Message}";
                SelectedLocation = new Location(37.7749, -122.4194);
                MapSpan = MapSpan.FromCenterAndRadius(
                    SelectedLocation,
                    Distance.FromKilometers(10));
            }
            finally
            {
                IsLoading = false;
            }
        }
        public async Task OnMapClickedAsync(Location location)
        {
            SelectedLocation = location;
            await GetAddressFromLocationAsync(location);
        }

        private async Task GetAddressFromLocationAsync(Location location)
        {
            try
            {
                var placemarks = await Geocoding.Default.GetPlacemarksAsync(location);
                var placemark = placemarks?.FirstOrDefault();

                if (placemark != null)
                {
                    LocationAddress = $"{placemark.Locality}, {placemark.AdminArea}";
                }
                else
                {
                    LocationAddress = $"{location.Latitude:F4}, {location.Longitude:F4}";
                }
            }
            catch
            {
                LocationAddress = $"{location.Latitude:F4}, {location.Longitude:F4}";
            }
        }

        [RelayCommand]
        private async Task SaveLocationAsync()
        {
            if (SelectedLocation == null || _currentUser == null)
            {
                ErrorMessage = "Please select a location";
                return;
            }

            try
            {
                IsLoading = true;
                ErrorMessage = string.Empty;

                _currentUser.Latitude = SelectedLocation.Latitude;
                _currentUser.Longitude = SelectedLocation.Longitude;
                _currentUser.LocationAddress = LocationAddress;

                await userRepository.UpdateUserAsync(_currentUser);

                var loginUser = loginService.CurrentUser;

                if (loginUser != null)
                {
                    loginUser.Latitude = _currentUser.Latitude;
                    loginUser.Longitude = _currentUser.Longitude;
                    loginUser.LocationAddress = _currentUser.LocationAddress;
                }

                await navigationService.GoBackAsync();
            }
            catch (Exception ex)
            {
                ErrorMessage = $"Failed to save location: {ex.Message}";
            }
            finally
            {
                IsLoading = false;
            }
        }

        [RelayCommand]
        private async Task CancelAsync()
        {
            await navigationService.GoBackAsync();
        }
    }
}