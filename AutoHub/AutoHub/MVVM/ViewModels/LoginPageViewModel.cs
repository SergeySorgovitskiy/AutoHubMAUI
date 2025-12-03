using AutoHub.Services.LoginService;
using AutoHub.Services.NavigationService;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.ComponentModel.DataAnnotations;

namespace AutoHub.MVVM.ViewModels
{
    public partial class LoginPageViewModel(
        INavigationService navigationService,
        ILoginService loginService) : ObservableValidator
    {
        [ObservableProperty]
        [Required(ErrorMessage = "Email is required!")]
        [EmailAddress(ErrorMessage = "Incorrect Email format!")]
        private string _email = string.Empty;

        [ObservableProperty]
        [Required(ErrorMessage = "The password cannot be empty.")]
        private string _password = string.Empty;

        [ObservableProperty]
        public partial string? ErrorMessage { get; set; }
        public bool HasErrorMessage => !string.IsNullOrEmpty(ErrorMessage);
        partial void OnErrorMessageChanged(string? value)
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
                ErrorMessage = firstError ?? string.Empty;
                return;
            }

            try
            {
                var user = await loginService.LoginAsync(Email, Password);

                if (user != null)
                {
                    await navigationService.GoToCatalogAsync();
                }
                else
                {
                    ErrorMessage = "Invalid login or password";
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = $"Login failed: {ex.Message}";
            }

        }

        [RelayCommand]
        private async Task GoToRegisterAsync()
        {
            await navigationService.GoToRegisterAsync();
        }

        [RelayCommand]
        private async Task ForgotPasswordAsync()
        {
            await navigationService.GoToForgotPasswordAsync(); 
        }

    }
}
