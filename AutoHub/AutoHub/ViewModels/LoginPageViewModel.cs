using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.ComponentModel.DataAnnotations;
namespace AutoHub.ViewModels
{
    public partial class LoginPageViewModel : ObservableValidator
    {
        [ObservableProperty]
        [Required(ErrorMessage = "Email не должен быть пустым")]
        [EmailAddress(ErrorMessage ="Это не похоже на email")]
        private string _email;

        [ObservableProperty]
        [Required(ErrorMessage = "Пароль не должен быть пустым")]
        private string _password;

        public LoginPageViewModel()
        {
            _email = string.Empty;
            _password = string.Empty;
        }

        //[RelayCommand] 
        //private async Task LoginAsync()
        //{
        //    ValidateAllProperties();
        //    if (HasErrors)
        //    {
        //        var firstError = GetErrors().FirstOrDefault()?.ErrorMessage;
        //    }
        //}
    }
}
