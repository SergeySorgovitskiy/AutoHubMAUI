using AutoHub.MVVM.Models;
using AutoHub.Services.DataService;
using AutoHub.Services.NavigationService;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.Logging;
using System.Collections.ObjectModel;

namespace AutoHub.MVVM.ViewModels
{
    public partial class CatalogPageViewModel : ObservableObject
    {
        private readonly IDataService _dataService;
        private readonly INavigationService _navigationService;
        private readonly ILogger<CatalogPageViewModel> _logger;

        [ObservableProperty]
        private ObservableCollection<CarListingModel> _cars;

        [ObservableProperty]
        private bool _isLoading;

        [ObservableProperty]
        private string? _searchQuery;

        public CatalogPageViewModel(IDataService dataService, INavigationService navigationService, ILogger<CatalogPageViewModel> logger)
        {
           
            _dataService = dataService;
            _navigationService = navigationService;
            _cars = new ObservableCollection<CarListingModel>();
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

                if (Cars.Count > 0) Cars.Clear();

                foreach (var car in carList)
                {
                    Cars.Add(car);
                }
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