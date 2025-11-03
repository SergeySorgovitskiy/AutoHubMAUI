using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using AutoHub.Views;
using AutoHub.ViewModels;
using AutoHub.Services.NavigationService;

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
                });
            builder.Services.AddSingletonWithShellRoute<LoginPage, LoginPageViewModel>("LoginPage");
            builder.Services.AddSingletonWithShellRoute<RegisterPage, RegisterPageViewModel>("RegisterPage");
            builder.Services.AddSingleton<INavigationService, NavigationService>();
#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
