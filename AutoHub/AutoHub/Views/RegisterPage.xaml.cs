using AutoHub.ViewModels;

namespace AutoHub.Views;

public partial class RegisterPage : ContentPage
{
	public RegisterPage(RegisterPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}