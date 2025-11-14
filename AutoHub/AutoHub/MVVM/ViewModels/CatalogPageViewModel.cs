using AutoHub.MVVM.Models;
using AutoHub.Services.DataService;
using AutoHub.Services.NavigationService;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.Logging;

namespace AutoHub.MVVM.ViewModels
{
    public partial class CatalogPageViewModel : ObservableObject
    {
        private readonly IDataService _mockService;
        private readonly INavigationService _navigationService;

        [ObservableProperty]
        private List<CarListingModel> _cars;

        [ObservableProperty]
        private bool _isLoading;

        private readonly ILogger<CatalogPageViewModel> _logger;
        public CatalogPageViewModel(IDataService mockService, INavigationService navigationService, ILogger<CatalogPageViewModel> logger)
        {
            _logger = logger;
            _mockService = mockService;
            _navigationService = navigationService;
            _cars = new List<CarListingModel>();
        }

        [RelayCommand]
        private async Task GoToDetailsAsync(CarListingModel car)
        {
 
           await _navigationService.GoToDetailsAsync(car.Id);
        }

        [RelayCommand]
        private async Task LoadCarsAsync()
        {
            if (IsLoading)
                return;
            try
            {

                var carList = await _mockService.GetListingsAsync();
                Cars = new List<CarListingModel>(carList);
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
    }
}