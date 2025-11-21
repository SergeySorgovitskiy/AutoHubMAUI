using AutoHub.MVVM.ViewModels;

namespace AutoHub.MVVM.Views
{
    public partial class FavoritePage : ContentPage
    {
        private readonly FavoritePageViewModel _vm;

        public FavoritePage(FavoritePageViewModel vm)
        {
            InitializeComponent();
            _vm = vm;
            BindingContext = _vm;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (_vm.FavoriteCars.Count == 0)
            {
                if (_vm.LoadCarsCommand.CanExecute(null))
                {
                    _vm.LoadCarsCommand.Execute(null);
                }
            }
        }
    }
}