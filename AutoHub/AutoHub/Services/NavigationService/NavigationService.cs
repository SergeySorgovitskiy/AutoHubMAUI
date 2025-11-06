using AutoHub.MVVM.Views;

namespace AutoHub.Services.NavigationService
{
    public class NavigationService : INavigationService
    {
        public Task GoToLoginAsync()
        {
            return Shell.Current.GoToAsync(nameof(LoginPage));
        }
        public Task GoToRegisterAsync()
        {
            return Shell.Current.GoToAsync(nameof(RegisterPage));
        }
        public Task GoToForgotPasswordAsync()
        {
            return Shell.Current.GoToAsync(nameof(RegisterPage));
        }
        public Task GoToCatalogAsync()
        {
            return Shell.Current.GoToAsync($"//{nameof(CatalogPage)}"); 
        }
        public Task GoBackAsync()
        {
            return Shell.Current.GoToAsync("..");
        }
    }
}
