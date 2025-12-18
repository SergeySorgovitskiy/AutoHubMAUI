using AutoHub.MVVM.ViewModels;
using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Devices.Sensors;

namespace AutoHub.MVVM.Views;

public partial class LocationPickerPage : ContentPage
{
    private LocationPickerPageViewModel? ViewModel => BindingContext as LocationPickerPageViewModel;

    public LocationPickerPage(LocationPickerPageViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        if (ViewModel != null)
        {
            await ViewModel.LoadUserLocationAsync();
            UpdateMap();
        }
    }

    private void UpdateMap()
    {
        if (ViewModel?.MapSpan != null)
        {
            LocationMap.MoveToRegion(ViewModel.MapSpan);

            LocationMap.Pins.Clear();
            if (ViewModel.SelectedLocation != null)
            {
                var pin = new Pin
                {
                    Label = "Your Location",
                    Location = ViewModel.SelectedLocation,
                    Type = PinType.Place
                };
                LocationMap.Pins.Add(pin);
            }
        }
    }

    private async void OnMapClicked(object? sender, MapClickedEventArgs e)
    {
        if (ViewModel != null && e.Location != null)
        {
            await ViewModel.OnMapClickedAsync(e.Location);
            UpdateMap();
        }
    }
}