using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui.Extensions;
using AutoHub.Views;              
using AutoHub.ViewModels;

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
            builder.Services.AddSingletonWithShellRoute<LoginPage, LoginPageViewModel>("RegisterPage");

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
