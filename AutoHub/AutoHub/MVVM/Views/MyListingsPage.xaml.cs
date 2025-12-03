using AutoHub.MVVM.ViewModels;

namespace AutoHub.MVVM.Views;

public partial class MyListingsPage : ContentPage
{
	public MyListingsPage(MyListingsPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
    }

	protected override void OnAppearing()
	{
		base.OnAppearing();
		if (BindingContext is MyListingsPageViewModel viewModel)
		{
			viewModel.OnAppearing();
		}
	}
}