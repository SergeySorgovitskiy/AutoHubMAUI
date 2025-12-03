using AutoHub.MVVM.Models;
using AutoHub.Services.Repositories.ListingRepository;
using AutoHub.Services.Repositories.UserRepository;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace AutoHub.MVVM.ViewModels
{
    [QueryProperty(nameof(CarId), "Id")]
    public partial class DetailsPageViewModel(
        IListingRepository dataService,
        IUserRepository userRepository) : ObservableObject
    {

        [ObservableProperty]
        public partial UserModel? Seller { get; set; }

        [ObservableProperty]
        public partial bool IsLoading { get; set; }

        [ObservableProperty]
        public partial int CarId { get; set; }

        [ObservableProperty]
        public partial ListingModel? Car { get; set; }

        [ObservableProperty]
        private ObservableCollection<ImageUrlModel> _images = new();

        [ObservableProperty]
        public partial string? ErrorMessage { get; set; }

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

                var carDetails = await dataService.GetDetailsByIdAsync(CarId);
                Car = carDetails;

                if (Car != null && Car.DetailsImagesUrls != null && Car.SellerUserId > 0)
                {
                    Seller = await userRepository.GetUserByIdAsync(Car.SellerUserId);

                    Images.Clear();
                    foreach (var url in Car.DetailsImagesUrls)
                    {
                        Images.Add(new ImageUrlModel(url));
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = $"Failed to load car details: {ex.Message}";
            }
            finally
            {
                IsLoading = false;
            }
        }
    }
}