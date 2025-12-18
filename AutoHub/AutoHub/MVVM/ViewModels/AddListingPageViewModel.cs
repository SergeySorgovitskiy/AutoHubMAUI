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
    public partial class AddListingPageViewModel(
            IListingRepository listingRepository,
            ILoginService loginService,
            INavigationService navigationService,
            IPhotoService photoService) : ObservableValidator
    {

        [ObservableProperty]
        private ObservableCollection<PhotoItem> _selectedImages = new();

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

            try
            {
                if (!string.IsNullOrEmpty(photo.FullPath))
                {
                    var imageSource = ImageSource.FromFile(photo.FullPath);
                    var photoItem = new PhotoItem(imageSource, photo.FullPath);
                    SelectedImages.Add(photoItem);
                    SelectedImagePaths.Add(photo.FullPath);
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = $"Failed to load photo: {ex.Message}";
            }
        }
        public void ClearForm()
        {
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
        private void RemoveImage(object parameter)
        {
            if (parameter is not PhotoItem photoItem) return;

            var index = SelectedImages.IndexOf(photoItem);
            if (index >= 0)
            {
                SelectedImages.RemoveAt(index);
                if (index < SelectedImagePaths.Count)
                {
                    SelectedImagePaths.RemoveAt(index);
                }
            }
        }

        [RelayCommand]
        private async Task AddListingAsync()
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

                var mainImageUrl = SelectedImagePaths.Count > 0 ? SelectedImagePaths[0] : null;

                var newListing = new ListingModel
                {
                    Title = Title,
                    Subtitle = string.IsNullOrWhiteSpace(Subtitle) ? null : Subtitle,
                    Year = Year,
                    Price = Price,
                    Mileage = Mileage,
                    Location = string.IsNullOrWhiteSpace(Location) ? null : Location,
                    Description = string.IsNullOrWhiteSpace(Description) ? null : Description,
                    ImageUrl = mainImageUrl,
                    IsElectric = IsElectric,
                    SellerUserId = currentUser.Id,
                    DetailsImagesUrls = SelectedImagePaths.ToList()
                };

                await listingRepository.AddListingAsync(newListing);

                ClearForm();

                await navigationService.GoToCatalogAsync();
            }
            catch (Exception ex)
            {
                ErrorMessage = $"Failed to add listing: {ex.Message}";
            }
            finally
            {
                IsLoading = false;
            }
        }
    }
}
