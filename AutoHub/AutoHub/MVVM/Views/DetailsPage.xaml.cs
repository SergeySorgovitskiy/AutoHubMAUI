using AutoHub.MVVM.ViewModels;

namespace AutoHub.MVVM.Views;

public partial class DetailsPage : ContentPage
{
    public DetailsPage(DetailsPageViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}