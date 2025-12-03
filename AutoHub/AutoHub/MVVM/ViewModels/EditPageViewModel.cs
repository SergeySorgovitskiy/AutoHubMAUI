using AutoHub.MVVM.Models;
using AutoHub.Services.LoginService;
using AutoHub.Services.NavigationService;
using AutoHub.Services.PhotoService;
using AutoHub.Services.Repositories.ListingRepository;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace AutoHub.MVVM.ViewModels
{

    [QueryProperty(nameof(CarId), "Id")]
    public partial class EditPageViewModel(
            IListingRepository listingRepository,
            ILoginService loginService,
            INavigationService navigationService,
            IPhotoService photoService) : ObservableValidator

    {

        [ObservableProperty]
        public partial ListingModel? CurrentCar { get; set; }

        [ObservableProperty]
        public partial int CarId { get; set; }

        [ObservableProperty]
        private ObservableCollection<ImageSource> _selectedImages = new();

        [ObservableProperty]
        private ObservableCollection<string> _selectedImagePaths = new();

        [ObservableProperty]
        [Required(ErrorMessage = "Title is required!")]
        [MaxLength(200, ErrorMessage = "Title must be no more than 200 characters")]
        private string _title = string.Empty;

        [ObservableProperty]
        [Required(ErrorMessage = "Subtitle is required!")]
        [MaxLength(100, ErrorMessage = "Subtitle must be no more than 100 characters")]
        private string _subtitle = string.Empty;

        [ObservableProperty]
        [Required(ErrorMessage = "Year is required!")]
        private string _yearText = string.Empty;

        [ObservableProperty]
        [Required(ErrorMessage = "Price is required!")]
        private string _priceText = string.Empty;

        [ObservableProperty]
        [Required(ErrorMessage = "Mileage is required!")]
        private string _mileageText = string.Empty;

        [Required(ErrorMessage = "Year is required!")]
        [Range(1900, 2025, ErrorMessage = "Year must be between 1900 and 2025")]
        public int Year { get; private set; }

        [Required(ErrorMessage = "Price is required!")]
        [Range(0, double.MaxValue, ErrorMessage = "Price must be positive")]
        public decimal Price { get; private set; }

        [Required(ErrorMessage = "Mileage is required!")]
        [Range(0, int.MaxValue, ErrorMessage = "Mileage must be positive")]
        public int Mileage { get; private set; }
        partial void OnYearTextChanged(string value)
        {
            if (int.TryParse(value, out var year))
            {
                Year = year;
            }
        }

        partial void OnPriceTextChanged(string value)
        {
            if (decimal.TryParse(value, out var price))
            {
                Price = price;
            }
        }

        partial void OnMileageTextChanged(string value)
        {
            if (int.TryParse(value, out var mileage))
            {
                Mileage = mileage;
            }
        }

        [ObservableProperty]
        [MaxLength(200, ErrorMessage = "Location must be no more than 200 characters")]
        private string _location = string.Empty;

        [ObservableProperty]
        [Required(ErrorMessage = "Price is required!")]
        [MaxLength(5000, ErrorMessage = "Description must be no more than 5000 characters")]
        private string _description = string.Empty;

        [ObservableProperty]
        public partial bool IsElectric { get; set; }

        [ObservableProperty]
        public partial bool IsLoading { get; set; }

        [ObservableProperty]
        public partial string ErrorMessage { get; set; } = string.Empty;

        public bool HasErrorMessage => !string.IsNullOrEmpty(ErrorMessage);

        partial void OnErrorMessageChanged(string value)
        {
            OnPropertyChanged(nameof(HasErrorMessage));
        }

        private void LoadPhoto(FileResult photo)
        {
            if (photo == null) return;

            var imageSource = ImageSource.FromFile(photo.FullPath);
            SelectedImages.Add(imageSource);
            SelectedImagePaths.Add(photo.FullPath);
        }

        private void ClearForm()
        {
            CurrentCar = null;
            Title = string.Empty;
            Subtitle = string.Empty;
            YearText = string.Empty;
            PriceText = string.Empty;
            MileageText = string.Empty;
            Location = string.Empty;
            Description = string.Empty;
            IsElectric = false;
            SelectedImages.Clear();
            SelectedImagePaths.Clear();
            ErrorMessage = string.Empty;
            Year = 0;
            Price = 0;
            Mileage = 0;
        }

        partial void OnCarIdChanged(int value)
        {
            ClearForm();
            if (value > 0)
            {
                Task.Run(() => LoadCarDetailsAsync(value));
            }
        }

        private async Task LoadCarDetailsAsync(int carId)
        {
            if (carId == 0)
            {
                ClearForm();
                return;
            }

            try 
            {
                IsLoading = true;
                ErrorMessage = string.Empty;

                var car = await listingRepository.GetDetailsByIdAsync(carId);

                if(car != null)
                {
                    CurrentCar = car;

                    Title = car.Title ?? string.Empty;
                    Subtitle = car.Subtitle ?? string.Empty;
                    Location = car.Location ?? string.Empty;
                    Description = car.Description ?? string.Empty;
                    IsElectric = car.IsElectric;

                    YearText = car.Year.ToString();
                    PriceText = car.Price.ToString();
                    MileageText = car.Mileage.ToString();

                    SelectedImagePaths.Clear();
                    SelectedImages.Clear();

                    if (car.DetailsImagesUrls != null)
                    {
                        foreach (var path in car.DetailsImagesUrls)
                        {
                            SelectedImagePaths.Add(path);
                            SelectedImages.Add(ImageSource.FromFile(path));
                        }
                    }
                }
                else
                {
                    ClearForm();
                    ErrorMessage = "Listing not found";
                }
            }
            catch (Exception ex)
            {
                ClearForm();
                ErrorMessage = $"Failed to load car details: {ex.Message}";
            }
            finally
            {
                IsLoading = false;
            }
        }


        [RelayCommand]
        private async Task PickPhotoAsync()
        {
            try
            {
                ErrorMessage = string.Empty;

                var remainingSlots = 12 - SelectedImages.Count;
                if (remainingSlots <= 0)
                {
                    ErrorMessage = "You can select up to 12 photos only.";
                    return;
                }

                var photos = await photoService.PickPhotosFromGalleryAsync(remainingSlots);

                if (photos == null || !photos.Any())
                {
                    return;
                }

                foreach (var photo in photos)
                {
                    if (photo != null && SelectedImages.Count < 12)
                    {
                        LoadPhoto(photo);
                    }
                    else if (SelectedImages.Count >= 12)
                    {
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = $"Failed to pick photo: {ex.Message}";
            }
        }

        [RelayCommand]
        private async Task TakePhotoAsync()
        {
            if (SelectedImages.Count >= 12)
            {
                ErrorMessage = "You can select up to 12 photos only.";
                return;
            }

            try
            {
                ErrorMessage = string.Empty;

                var photo = await photoService.TakePhotoFromCameraAsync();

                if (photo == null)
                {
                    ErrorMessage = "Photo capture was cancelled or failed.";
                    return;
                }

                LoadPhoto(photo);
            }
            catch (Exception ex)
            {
                ErrorMessage = $"Failed to take photo: {ex.Message}";
            }
        }


        [RelayCommand]
        private async Task SaveListingAsync()
        {
            ErrorMessage = string.Empty;

            if (!int.TryParse(YearText, out var year) || year < 1900 || year > 2025)
            {
                ErrorMessage = "Year must be a valid number between 1900 and 2025";
                return;
            }

            if (!decimal.TryParse(PriceText, out var price) || price <= 0)
            {
                ErrorMessage = "Price must be a valid positive number";
                return;
            }

            if (!int.TryParse(MileageText, out var mileage) || mileage < 0)
            {
                ErrorMessage = "Mileage must be a valid positive number";
                return;
            }

            Year = year;
            Price = price;
            Mileage = mileage;

            ValidateAllProperties();

            if (HasErrors)
            {
                var firstError = GetErrors().FirstOrDefault()?.ErrorMessage;
                ErrorMessage = firstError ?? string.Empty;
                return;
            }

            var currentUser = loginService.CurrentUser;
            if (currentUser == null)
            {
                ErrorMessage = "You must be logged in to add a listing";
                return;
            }

            try
            {
                IsLoading = true;

                var listingToSave = CurrentCar ?? new ListingModel();

                var mainImageUrl = SelectedImagePaths.Count > 0 ? SelectedImagePaths[0] : listingToSave.ImageUrl;

                listingToSave.Title = Title;
                listingToSave.Subtitle = string.IsNullOrWhiteSpace(Subtitle) ? null : Subtitle;
                listingToSave.Year = Year;
                listingToSave.Price = Price;
                listingToSave.Mileage = Mileage;
                listingToSave.Location = string.IsNullOrWhiteSpace(Location) ? null : Location;
                listingToSave.Description = string.IsNullOrWhiteSpace(Description) ? null : Description;
                listingToSave.IsElectric = IsElectric;
                listingToSave.ImageUrl = mainImageUrl;
                listingToSave.DetailsImagesUrls = SelectedImagePaths.ToList();

                await listingRepository.UpdateListingAsync(listingToSave);
               
                await navigationService.GoToMyListingsAsync(currentUser.Id);
            }
            catch (Exception ex)
            {
                ErrorMessage = $"Failed to save listing: {ex.Message}";
            }
            finally
            {
                IsLoading = false;
            }
        }
    }
}
