using AutoHub.MVVM.ViewModels;

namespace AutoHub.MVVM.Views;

public partial class RegisterPage : ContentPage
{
	public RegisterPage(RegisterPageViewModel vm)
	{
        InitializeComponent();
        BindingContext = vm; 
    }
}