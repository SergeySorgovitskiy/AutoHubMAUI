using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using AutoHub.MVVM.Views;
using AutoHub.MVVM.ViewModels;
using AutoHub.Services.NavigationService;
using AutoHub.Services.LoginService;
using AutoHub.Services.RegisterService;
using AutoHub.Services.Repositories.ListingRepository;
using AutoHub.Services.Repositories.UserRepository;
using AutoHub.Services.DbService;
using AutoHub.Services.PhotoService;
using Plugin.Maui.Biometric;

#if IOS
using UIKit;
#endif

namespace AutoHub
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .UseMauiMaps()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                }).ConfigureMauiHandlers(handlers =>
                {

#if ANDROID
                    Platforms.Android.PlatformConfig.ConfigurePlatform();
#endif

                });

            builder.Services.AddTransientWithShellRoute<LoginPage, LoginPageViewModel>(nameof(LoginPage));
            builder.Services.AddTransientWithShellRoute<RegisterPage, RegisterPageViewModel>(nameof(RegisterPage));
            builder.Services.AddTransientWithShellRoute<CatalogPage, CatalogPageViewModel>(nameof(CatalogPage));
            builder.Services.AddTransientWithShellRoute<DetailsPage, DetailsPageViewModel>(nameof(DetailsPage));
            builder.Services.AddTransientWithShellRoute<FavoritePage, FavoritePageViewModel>(nameof(FavoritePage));
            builder.Services.AddTransientWithShellRoute<AddListingPage, AddListingPageViewModel>(nameof(AddListingPage));
            builder.Services.AddTransientWithShellRoute<EditPage, EditPageViewModel>(nameof(EditPage));
            builder.Services.AddTransientWithShellRoute<MyListingsPage, MyListingsPageViewModel>(nameof(MyListingsPage));
            builder.Services.AddTransientWithShellRoute<ProfilePage, ProfilePageViewModel>(nameof(ProfilePage));
            builder.Services.AddTransientWithShellRoute<EditProfilePage, EditProfilePageViewModel>(nameof(EditProfilePage));
            builder.Services.AddTransientWithShellRoute<LocationPickerPage, LocationPickerPageViewModel>(nameof(LocationPickerPage));
            builder.Services.AddSingleton<INavigationService, NavigationService>();
            builder.Services.AddSingleton<IListingRepository, ListingRepository>();
            builder.Services.AddSingleton<IUserRepository, UserRepository>();
            builder.Services.AddSingleton<ILoginService, LoginService>();
            builder.Services.AddSingleton<IRegisterService, RegisterService>();
            builder.Services.AddSingleton<IDbService, DbService>();
            builder.Services.AddSingleton<IPhotoService, PhotoService>();
            builder.Services.AddSingleton<IBiometric>(BiometricAuthenticationService.Default);

#if DEBUG
            builder.Logging.AddDebug();
#endif
            var app = builder.Build();

            Task.Run(async () =>
            {
                try
                {
                    await Task.Delay(500);
                    var dbService = app.Services.GetRequiredService<IDbService>();
                    await dbService.InitializeAsync();
                }
                catch (Exception)
                {
                }
            });

            return app;
        }
    }
}