using AutoHub.MVVM.Models;
using AutoHub.MVVM.Views;
using AutoHub.Services.LoginService;
using AutoHub.Services.NavigationService;
using AutoHub.Services.PhotoService;
using AutoHub.Services.Repositories.UserRepository;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace AutoHub.MVVM.ViewModels
{
    public partial class EditProfilePageViewModel(
        IUserRepository userRepository,
        ILoginService loginService,
        IPhotoService photoService,
        INavigationService navigationService) : ObservableValidator
    {
        [ObservableProperty]
        public partial UserModel? CurrentUser { get; set; }

        [ObservableProperty]
        public partial ImageSource? ProfileImage { get; set; }

        [ObservableProperty]
        public partial string ProfileImagePath { get; set; } = string.Empty;

        [ObservableProperty]
        [Required(ErrorMessage = "Name is required!")]
        [MaxLength(100, ErrorMessage = "Name must be no more than 100 characters")]
        private string _name = string.Empty;

        [ObservableProperty]
        [Required(ErrorMessage = "Email is required!")]
        [MaxLength(255, ErrorMessage = "Email must be no more than 255 characters")]
        private string _email = string.Empty;

        [ObservableProperty]
        [MaxLength(20, ErrorMessage = "Phone number must be no more than 20 characters")]
        private string _phoneNumber = string.Empty;

        [ObservableProperty]
        public partial bool IsLoading { get; set; }

        [ObservableProperty]
        public partial string ErrorMessage { get; set; } = string.Empty;

        public bool HasErrorMessage => !string.IsNullOrEmpty(ErrorMessage);

        partial void OnErrorMessageChanged(string value)
        {
            OnPropertyChanged(nameof(HasErrorMessage));
        }

        public async Task LoadUserDataAsync()
        {
            var user = loginService.CurrentUser;
            if (user == null) return;

            CurrentUser = await userRepository.GetUserByIdAsync(user.Id);
            if (CurrentUser == null) return;

            Name = CurrentUser.Name;
            Email = CurrentUser.Email;
            PhoneNumber = CurrentUser.PhoneNumber;
            ProfileImagePath = CurrentUser.ProfileImageUrl;
            
            if (!string.IsNullOrEmpty(ProfileImagePath) && ProfileImagePath != "default_profile_image.jpg")
            {
                ProfileImage = ImageSource.FromFile(ProfileImagePath);
            }
        }

        [RelayCommand]
        private async Task PickPhotoAsync()
        {
            try
            {
                ErrorMessage = string.Empty;
                var photo = await photoService.PickPhotosFromGalleryAsync(1);
                var firstPhoto = photo?.FirstOrDefault();

                if (firstPhoto != null)
                {
                    ProfileImagePath = firstPhoto.FullPath;
                    ProfileImage = ImageSource.FromFile(ProfileImagePath);
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
            try
            {
                ErrorMessage = string.Empty;
                var photo = await photoService.TakePhotoFromCameraAsync();

                if (photo != null)
                {
                    ProfileImagePath = photo.FullPath;
                    ProfileImage = ImageSource.FromFile(ProfileImagePath);
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = $"Failed to take photo: {ex.Message}";
            }
        }

        [RelayCommand]
        private async Task SaveProfileAsync()
        {
            ErrorMessage = string.Empty;

            ValidateAllProperties();

            if (HasErrors)
            {
                var firstError = GetErrors().FirstOrDefault()?.ErrorMessage;
                ErrorMessage = firstError ?? string.Empty;
                return;
            }

            if (CurrentUser == null)
            {
                ErrorMessage = "You must be logged in to edit profile";
                return;
            }

            try
            {
                IsLoading = true;

                CurrentUser.Name = Name;
                CurrentUser.Email = Email;
                CurrentUser.PhoneNumber = PhoneNumber;
                CurrentUser.ProfileImageUrl = ProfileImagePath;

                await userRepository.UpdateUserAsync(CurrentUser);

                var loginUser = loginService.CurrentUser;
                if (loginUser != null)
                {
                    loginUser.Name = Name;
                    loginUser.Email = Email;
                    loginUser.PhoneNumber = PhoneNumber;
                    loginUser.ProfileImageUrl = ProfileImagePath;
                }

                await navigationService.GoToProfileAsync();
            }
            catch (Exception ex)
            {
                ErrorMessage = $"Failed to save profile: {ex.Message}";
            }
            finally
            {
                IsLoading = false;
            }
        }
    }
}
