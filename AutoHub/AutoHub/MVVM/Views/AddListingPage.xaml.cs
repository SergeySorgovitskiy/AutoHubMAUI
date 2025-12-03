using AutoHub.MVVM.ViewModels;

namespace AutoHub.MVVM.Views;

public partial class AddListingPage : ContentPage
{
	public AddListingPage(AddListingPageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}