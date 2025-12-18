using AutoHub.MVVM.ViewModels;
using Microsoft.Maui.ApplicationModel;
using Microsoft.Maui.Devices;

namespace AutoHub.MVVM.Views;

public partial class MyListingsPage : ContentPage
{
	private readonly MyListingsPageViewModel _vm;

	public MyListingsPage(MyListingsPageViewModel vm)
	{
		InitializeComponent();
		_vm = vm;
		BindingContext = _vm;
	}

	protected override async void OnAppearing()
	{
		base.OnAppearing();


		if (DeviceInfo.Platform == DevicePlatform.iOS)
		{
			await Task.Delay(500);
		}

		if (_vm.LoadCarsCommand.CanExecute(null))
		{
			_vm.LoadCarsCommand.Execute(null);
		}
	}
}