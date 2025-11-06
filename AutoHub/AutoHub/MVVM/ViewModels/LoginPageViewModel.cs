using AutoHub.Services.NavigationService;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.ComponentModel.DataAnnotations;

namespace AutoHub.MVVM.ViewModels
{
    public partial class LoginPageViewModel : ObservableValidator
    {
        private readonly INavigationService _navigationService;

        public LoginPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        [ObservableProperty]
        [Required(ErrorMessage = "Email is required!")]
        [EmailAddress(ErrorMessage = "Incorrect Email format!")]
        private string _email = string.Empty;

        [ObservableProperty]
        [Required(ErrorMessage = "The password must not be empty.")]
        private string _password = string.Empty;

        [RelayCommand]
        private async Task LoginAsync()
        {
            ValidateAllProperties();

            if (HasErrors)
            {
                var firstError = GetErrors().FirstOrDefault()?.ErrorMessage;
                await Application.Current.MainPage.DisplayAlert("Error", firstError, "OK");

                return;
            }

            await Application.Current.MainPage.DisplayAlert("Success!", "Login successful!", "ОК");

            await _navigationService.GoToCatalogAsync();
            
        }

        [RelayCommand]
        private async Task GoToRegisterAsync()
        {
            await _navigationService.GoToRegisterAsync();
        }

        [RelayCommand]
        private async Task ForgotPasswordAsync()
        {
            await _navigationService.GoToForgotPasswordAsync(); 
        }

    }
}
