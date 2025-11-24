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
        private readonly IDataService _dataService;
        private readonly INavigationService _navigationService;
        private readonly ILogger<CatalogPageViewModel> _logger;

        [ObservableProperty]
        private List<CarListingModel> _cars = [];

        [ObservableProperty]
        private bool _isLoading;

        [ObservableProperty]
        private string? _searchQuery;

        public CatalogPageViewModel(IDataService dataService, INavigationService navigationService, ILogger<CatalogPageViewModel> logger)
        {
           
            _dataService = dataService;
            _navigationService = navigationService;
            
        }

        [RelayCommand]
        private async Task GoToDetailsAsync(CarListingModel car)
        {
            if (car == null) return;
            await _navigationService.GoToDetailsAsync(car.Id);
        }

        [RelayCommand]
        private async Task LoadCarsAsync()
        {

            try
            {
                IsLoading = true;

                var carList = await _dataService.GetListingsAsync();

                Cars = carList;
                
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