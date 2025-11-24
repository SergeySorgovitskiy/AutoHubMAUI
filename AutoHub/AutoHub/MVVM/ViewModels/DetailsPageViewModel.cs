using AutoHub.MVVM.Models;
using AutoHub.Services.DataService;
using AutoHub.Services.NavigationService;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.Logging;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace AutoHub.MVVM.ViewModels
{
    [QueryProperty(nameof(CarId), "Id")]
    public partial class DetailsPageViewModel : ObservableObject
    {
        private readonly IDataService _dataService;
        private readonly INavigationService _navigationService;
        private readonly ILogger<CatalogPageViewModel> _logger;
        public DetailsPageViewModel(INavigationService navigationService, IDataService dataService, ILogger<CatalogPageViewModel> logger)
        {
            _logger = logger;
            _navigationService = navigationService;
            _dataService = dataService;
            _images = new ObservableCollection<ImageUrlModel>();
            
        }

        [ObservableProperty]
        private bool _isLoading;

        [ObservableProperty]
        private int _carId;

        [ObservableProperty]
        private CarListingModel _car;

        [ObservableProperty]
        private ObservableCollection<ImageUrlModel> _images; 

        partial void OnCarIdChanged(int value)
        {
            if (value > 0)
            {
                LoadCarDetailsCommand.Execute(null);
            }
        }


        [RelayCommand]
        private async Task LoadCarDetailsAsync()
        {
            if (IsLoading) return;

            try
            {

                IsLoading = true;

                Car = await _dataService.GetDetailsByIdAsync(CarId);

                if (Car != null && Car.DetailsImagesUrls != null)
                {
                    Images.Clear();
                    foreach (var url in Car.DetailsImagesUrls)
                    {
                        Images.Add(new ImageUrlModel(url));
                    }
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