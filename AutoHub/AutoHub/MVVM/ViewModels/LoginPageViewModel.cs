using AutoHub.Services.LoginService;
using AutoHub.Services.NavigationService;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.ComponentModel.DataAnnotations;

namespace AutoHub.MVVM.ViewModels
{
    public partial class LoginPageViewModel : ObservableValidator
    {
        private readonly INavigationService _navigationService;
        private readonly ILoginService _loginService;

        public LoginPageViewModel(INavigationService navigationService, ILoginService loginService)
        {
            _navigationService = navigationService;
            _loginService = loginService;
        }

        [ObservableProperty]
        [Required(ErrorMessage = "Email is required!")]
        [EmailAddress(ErrorMessage = "Incorrect Email format!")]
        private string _email = string.Empty;

        [ObservableProperty]
        [Required(ErrorMessage = "The password cannot be empty.")]
        private string _password = string.Empty;

        [ObservableProperty]
        private string _errorMessage;
        public bool HasErrorMessage => !string.IsNullOrEmpty(ErrorMessage);
        partial void OnErrorMessageChanged(string value)
        {
            OnPropertyChanged(nameof(HasErrorMessage));
        }

        [RelayCommand]
        private async Task LoginAsync()
        {
            ErrorMessage = string.Empty;

            ValidateAllProperties();

            if (HasErrors)
            {
                var firstError = GetErrors().FirstOrDefault()?.ErrorMessage;
                ErrorMessage = firstError;
                return;
            }

            var user = await _loginService.LoginAsync(Email, Password);
            if (user != null)
            {
                await _navigationService.GoToCatalogAsync();
            }
            else
            {
                ErrorMessage = "Invalid login or password";
            }

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
