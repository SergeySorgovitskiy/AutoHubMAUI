using AutoHub.MVVM.Models;
using AutoHub.Services.MockService;
using AutoHub.Services.NavigationService;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace AutoHub.MVVM.ViewModels
{
    public partial class CatalogPageViewModel : ObservableValidator
    {
        private readonly IMockService _mockService;
        private readonly INavigationService _navigationService;

        [ObservableProperty]
        private ObservableCollection<CarListingModel> _cars;

        [ObservableProperty]
        private bool _isLoading;
        public CatalogPageViewModel(IMockService mockService, INavigationService navigationService)
        {
            _mockService = mockService;
            _navigationService = navigationService;
            _cars = new ObservableCollection<CarListingModel>();
        }

        [RelayCommand]
        private async Task LoadCarsAsync()
        {
            if (IsLoading)
                return;
            try
            {
                IsLoading = true;
                await Task.Delay(2000);
                var carList = await _mockService.GetListingsAsync();
                Cars.Clear();
                foreach (var car in carList)
                {
                    Cars.Add(car);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"[LoadCarsAync] Error: {ex.Message}");
                await Shell.Current.DisplayAlert("Error", "Can't load list", "OK");
            }
            finally
            {
                IsLoading = false;
            }
        }
    }
}