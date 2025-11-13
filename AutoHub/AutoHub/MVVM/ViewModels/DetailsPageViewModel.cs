using AutoHub.MVVM.Models;
using AutoHub.Services.MockService;
using AutoHub.Services.NavigationService;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace AutoHub.MVVM.ViewModels
{
    [QueryProperty(nameof(CarId), "Id")]
    public partial class DetailsPageViewModel : ObservableValidator
    {
        private readonly IMockService _mockService;
        private readonly INavigationService _navigationService;
        public DetailsPageViewModel(INavigationService navigationService, IMockService mockService)
        {
            _navigationService = navigationService;
            _mockService = mockService;
            _images = new ObservableCollection<ImageUrlModel>();
            
        }

        [ObservableProperty]
        private bool _isBusy;

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
            if (IsBusy) return;

            try
            {

                IsBusy = true;

                Car = await _mockService.GetDetailsByIdAsync(CarId);

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
                Debug.WriteLine($"[LoadCarDetailsAsync] Error: {ex.Message}");
                await Application.Current.MainPage.DisplayAlert("Error", "Failed to load car details.", "OK");
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}