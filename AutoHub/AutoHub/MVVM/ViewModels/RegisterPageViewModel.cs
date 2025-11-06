using AutoHub.Services.NavigationService;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.ComponentModel.DataAnnotations;

namespace AutoHub.MVVM.ViewModels
{
    public partial class RegisterPageViewModel : ObservableValidator
    {
        private readonly INavigationService _navigationService;
        public RegisterPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        [ObservableProperty]
        [Required(ErrorMessage = "Username is required!")]
        [MinLength(3, ErrorMessage = "Username must be at least 3 characters long")]
        [MaxLength(20, ErrorMessage = "Username must be no more than 20 characters long")]
        [RegularExpression(@"^[a-zA-Z]*$", ErrorMessage = "Only letters are allowed")]
        private string _name = string.Empty;

        [ObservableProperty]
        [Required(ErrorMessage = "Email is required!")]
        [EmailAddress(ErrorMessage = "Invalid Email format!")]
        private string _email = string.Empty;

        [ObservableProperty]
        [Required(ErrorMessage = "Phone number is required!")]
        [Phone(ErrorMessage = "Invalid phone number!")]
        private string _phoneNumber = string.Empty;

        [ObservableProperty]
        [Required(ErrorMessage = "Password cannot be empty")]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters long!")]
        private string _password = string.Empty;

        [ObservableProperty]
        [Required(ErrorMessage = "Please confirm your password")]
        private string _confirmPassword = string.Empty;

        [RelayCommand]
        private async Task CreateAccountAsync()
        {
            if (Password != ConfirmPassword)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Passwords do not match!", "OK");
                return;
            }

            ValidateAllProperties();

            if (HasErrors)
            {
                var firstError = GetErrors().FirstOrDefault()?.ErrorMessage;
                await Application.Current.MainPage.DisplayAlert("Error", firstError, "OK");
                return;
            }

            await Application.Current.MainPage.DisplayAlert("Success!", "Account created!", "OK");

            await _navigationService.GoToCatalogAsync();
        }

        [RelayCommand]
        private async Task BackToLoginAsync()
        {
            await _navigationService.GoBackAsync();
        }
    }
}