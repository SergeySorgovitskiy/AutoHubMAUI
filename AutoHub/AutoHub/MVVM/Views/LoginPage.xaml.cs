using AutoHub.MVVM.ViewModels;

namespace AutoHub.MVVM.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage(LoginPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}