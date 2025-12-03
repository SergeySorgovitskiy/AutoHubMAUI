using AutoHub.MVVM.ViewModels;

namespace AutoHub.MVVM.Views;

public partial class EditPage : ContentPage
{
	public EditPage(EditPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
    }
}