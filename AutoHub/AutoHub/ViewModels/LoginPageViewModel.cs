using AutoHub.Services.NavigationService;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.ComponentModel.DataAnnotations;

namespace AutoHub.ViewModels
{
    public partial class LoginPageViewModel : ObservableValidator
    {
        private readonly INavigationService _navigationService;

        public LoginPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        [ObservableProperty]
        [Required(ErrorMessage = "Email не должен быть пустым!")]
        [EmailAddress(ErrorMessage = "Неверный формат Email!")]
        private string _email = "";

        [ObservableProperty]
        [Required(ErrorMessage = "Пароль не должен быть пустым")]
        private string _password = "";

        [RelayCommand]
        private async Task LoginAsync()
        {
            ValidateAllProperties();

            if (HasErrors)
            {
                var firstError = GetErrors().FirstOrDefault()?.ErrorMessage;
                await Application.Current.MainPage.DisplayAlert("Ошибка", firstError, "OK");

                return;
            }

            await Application.Current.MainPage.DisplayAlert("Успех!", "Вход выполнен!", "ОК");

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
