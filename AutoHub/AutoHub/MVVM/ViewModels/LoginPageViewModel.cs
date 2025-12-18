using AutoHub.Services.LoginService;
using AutoHub.Services.NavigationService;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
//using CoreImage;
using Plugin.Maui.Biometric;
using System.ComponentModel.DataAnnotations;

namespace AutoHub.MVVM.ViewModels
{
    public partial class LoginPageViewModel(
        INavigationService navigationService,
        ILoginService loginService,
        IBiometric biometric) : ObservableValidator
    {
        [ObservableProperty]
        private bool isBiometricLoginVisible;

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

        public async Task CheckSavedCredentialsAsync()
        {
            var savedEmail = await SecureStorage.GetAsync("user_email");
            IsBiometricLoginVisible = !string.IsNullOrEmpty(savedEmail);    
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
                    if(!isBiometricLoginVisible)
                    {
                        await SaveCredentialsAsync(Email, Password);
                    }
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

        private async Task SaveCredentialsAsync(string email, string password)
        {
            bool answer = await Shell.Current.DisplayAlertAsync("Face ID", "Use Face ID to quick login in the future?", "Yes","No");

            if(answer)
            {
                await SecureStorage.SetAsync("user_email", email);
                await SecureStorage.SetAsync("user_password", password);
                IsBiometricLoginVisible = true; 
            }
        }

        [RelayCommand]
        private async Task BiometricLoginAsync()
        {
            var request = new AuthenticationRequest
            {
                Title = "Login in AutoHub",
                Subtitle = "Сonfirm your identity",
                Description = "For automatic login",
                NegativeText = "Cancel",
            };

            var result = await biometric.AuthenticateAsync(request, CancellationToken.None);

            if(result.Status == BiometricResponseStatus.Success)
            {
                var savedEmail = await SecureStorage.GetAsync("user_email");
                var savedPassword = await SecureStorage.GetAsync("user_password");

                if(!string.IsNullOrEmpty(savedEmail)&& !string.IsNullOrEmpty(savedPassword))
                {
                        Email = savedEmail;
                        Password = savedPassword;
                        await LoginAsync();
                }
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
