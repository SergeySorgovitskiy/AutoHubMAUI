using AutoHub.MVVM.ViewModels;

namespace AutoHub.MVVM.Views;

public partial class EditProfilePage : ContentPage
{
	public EditProfilePage(EditProfilePageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}

	protected override void OnAppearing()
	{
		base.OnAppearing();
		if (BindingContext is EditProfilePageViewModel viewModel)
		{
			viewModel.LoadUserDataAsync();
		}
	}
}