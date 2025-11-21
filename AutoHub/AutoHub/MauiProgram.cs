using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using AutoHub.MVVM.Views;
using AutoHub.MVVM.ViewModels;
using AutoHub.Services.NavigationService;
using AutoHub.Services.LoginService;
using AutoHub.Services.RegisterService;
using AutoHub.Services.Repositories.ListingRepository;
using AutoHub.Services.Repositories.UserRepository;
using AutoHub.Services.AppMemoryStore;

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
            builder.Services.AddSingleton<INavigationService, NavigationService>();
            builder.Services.AddSingleton<IListingRepository, ListingRepository>();
            builder.Services.AddSingleton<IUserRepository, UserRepository>();
            builder.Services.AddSingleton<ILoginService, LoginService>();
            builder.Services.AddSingleton<IRegisterService, RegisterService>();
            builder.Services.AddSingleton<Store>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}