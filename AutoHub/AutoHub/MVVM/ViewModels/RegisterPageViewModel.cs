using AutoHub.MVVM.Models;
using AutoHub.Services.NavigationService;
using AutoHub.Services.RegisterService;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.ComponentModel.DataAnnotations;

namespace AutoHub.MVVM.ViewModels
{
    public partial class RegisterPageViewModel(
        INavigationService navigationService, 
        IRegisterService registerService) : ObservableValidator
    {
        [ObservableProperty]
        [Required(ErrorMessage = "Username is required!")]
        [MinLength(3, ErrorMessage = "The username must be at least 3 characters long")]
        [MaxLength(20, ErrorMessage = "The username must be no more than 20 characters long.")]
        [RegularExpression(@"^[a-zA-Z]*$", ErrorMessage = "Only letters are allowed")]
        private string _name = string.Empty;

        [ObservableProperty]
        [Required(ErrorMessage = "Email is required!")]
        [EmailAddress(ErrorMessage = "Incorrect Email format!")]
        private string _email = string.Empty;

        [ObservableProperty]
        [Required(ErrorMessage = "A phone number is required!")]
        [Phone(ErrorMessage = "Incorrect phone number format!")]
        private string _phoneNumber = string.Empty;

        [ObservableProperty]
        private bool _isPasswordLengthValid;
        [ObservableProperty]
        private bool _isPasswordUpperCaseValid;
        [ObservableProperty]
        private bool _isPasswordNumberValid;

        private string _password = string.Empty;

        [Required(ErrorMessage = "The password cannot be empty!")]
        [MinLength(8, ErrorMessage = "The password must be at least 8 characters long!")]
        public string Password
        {
            get => _password;
            set
            {
                SetProperty(ref _password, value, validate: true);
                IsPasswordLengthValid = value.Length >= 8;
                IsPasswordNumberValid = value.Any(char.IsDigit);
                IsPasswordUpperCaseValid = value.Any(char.IsUpper);

            }
        }

        private string _confirmPassword = string.Empty;

        [Required(ErrorMessage = "Please, confirm your password!")]
        [Compare(nameof(Password), ErrorMessage = "Passwords don't match!")]
        public string ConfirmPassword
        {
            get => _confirmPassword;
            set => SetProperty(ref _confirmPassword, value, validate: true);
        }
      
        [ObservableProperty]
        public partial string ErrorMessage { get; set; } = string.Empty;

        public bool HasErrorMessage => !string.IsNullOrEmpty(ErrorMessage);

        partial void OnErrorMessageChanged(string value)
        {
            OnPropertyChanged(nameof(HasErrorMessage));
        }

        [RelayCommand]
        private async Task CreateAccountAsync()
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
                var newUser = new UserModel
                {
                    Name = Name,
                    Email = Email,
                    Password = Password,
                    PhoneNumber = PhoneNumber
                };

                bool isSuccess = await registerService.RegisterAsync(newUser);

                if (isSuccess)
                {
                    await navigationService.GoToLoginAsync();
                }
                else
                {
                    ErrorMessage = "A user with this email already exists.";
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
        }

        [RelayCommand]
        private async Task BackToLoginAsync()
        {
            await navigationService.GoBackAsync();
        }
    }
}