namespace AutoHub.Services.NavigationService
{
    public class NavigationService : INavigationService
    {
        public Task GoToLoginAsync()
        {
            return Shell.Current.GoToAsync("///LoginPage");
        }
        public Task GoToRegisterAsync()
        {
            return Shell.Current.GoToAsync("RegisterPage");
        }
        public Task GoToForgotPasswordAsync()
        {
            return Shell.Current.GoToAsync("///ForgotPasswordPage");
        }
        public Task GoToCatalogAsync()
        {
            return Shell.Current.GoToAsync("///CatalogPage");
        }
        public Task GoBackAsync()
        {
            return Shell.Current.GoToAsync("..");
        }
    }
}
