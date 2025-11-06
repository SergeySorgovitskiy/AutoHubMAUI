using AutoHub.MVVM.ViewModels;

namespace AutoHub.MVVM.Views;

public partial class CatalogPage : ContentPage
{
	public CatalogPage(CatalogPageViewModel vm)
	{
		BindingContext = vm;
		InitializeComponent();
	}

	protected override void OnAppearing()
	{
		base.OnAppearing();
		if (BindingContext is CatalogPageViewModel vm)
		{
			if (!vm.IsLoading && (vm.Cars == null || vm.Cars.Count == 0))
			{
				vm.LoadCarsCommand.Execute(null);
			}
		}
	}
}