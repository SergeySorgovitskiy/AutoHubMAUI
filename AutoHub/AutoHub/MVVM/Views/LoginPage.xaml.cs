using AutoHub.MVVM.ViewModels;

namespace AutoHub.MVVM.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage(LoginPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
	
	protected override async void OnAppearing()
    {
        base.OnAppearing();

		if(BindingContext is LoginPageViewModel vm)
        {
            await vm.CheckSavedCredentialsAsync();
        }
    }
}