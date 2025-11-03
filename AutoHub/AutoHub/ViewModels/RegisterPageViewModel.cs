using AutoHub.Services.NavigationService;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.ComponentModel.DataAnnotations;

namespace AutoHub.ViewModels
{
    public partial class RegisterPageViewModel : ObservableValidator
    {
        private readonly INavigationService _navigationService;
        public RegisterPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        [ObservableProperty]
        [Required(ErrorMessage = "Имя пользовтеля обязательно!")]
        [MinLength(3,ErrorMessage = "Имя пользователя должно содержать минимум три символа")]
        [MaxLength(20, ErrorMessage = "Имя пользователя должно содержать максиум 20 символов")]
        [RegularExpression(@"^[a-zA-Z]*$", ErrorMessage = "Можно испольовать только буквы")]
        private string _name = "";

        [ObservableProperty]
        [Required(ErrorMessage = "Почта обязательна!")]
        [EmailAddress(ErrorMessage ="Неправильный формат Email!")]
        private string _email = "";

        [ObservableProperty]
        [Required(ErrorMessage = "Обязательно введите телефон!")]
        [Phone(ErrorMessage ="Неверный номер телефона!")]
        private string _phoneNumber = "";

        [ObservableProperty]
        [Required(ErrorMessage = "Пароль не должен быть пустым")]
        [MinLength(8, ErrorMessage ="Пароль должен быть от 8 символов!")]
        private string _password = "";

        [ObservableProperty]
        [Required(ErrorMessage = "Подтвердите пароль")]
        private string _confirmPassword = "";

        [RelayCommand]
        private async Task CreateAccountAsync()
        {
            if(Password != ConfirmPassword)
            {
                await Application.Current.MainPage.DisplayAlert("Ошибка", "Пароли не совпадают!", "OK");

                return;
            }

            ValidateAllProperties();

            if(HasErrors)
            {
                var firstError = GetErrors().FirstOrDefault()?.ErrorMessage;
                await Application.Current.MainPage.DisplayAlert("Ошибка", firstError, "ОК");

                return;
            }

            await Application.Current.MainPage.DisplayAlert("Успех!", "Аккаунт создан!", "ОК");

            await _navigationService.GoToCatalogAsync(); ;
        }
        [RelayCommand]
        private async Task BackToLoginAsync()
        {
            await _navigationService.GoBackAsync(); ;
        }
    }
}
