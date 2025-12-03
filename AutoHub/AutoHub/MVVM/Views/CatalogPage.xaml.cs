using AutoHub.MVVM.ViewModels;

namespace AutoHub.MVVM.Views;

public partial class CatalogPage : ContentPage
{
    private readonly CatalogPageViewModel _vm;
    public CatalogPage(CatalogPageViewModel vm)
    {
        InitializeComponent();
        _vm = vm;
        BindingContext = _vm;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        if (_vm.LoadCarsCommand.CanExecute(null))
        {
            _vm.LoadCarsCommand.Execute(null);
        }
    }
}