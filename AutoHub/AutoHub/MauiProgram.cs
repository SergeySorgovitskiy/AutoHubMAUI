using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using AutoHub.MVVM.Views;
using AutoHub.MVVM.ViewModels;
using AutoHub.Services.NavigationService;
using AutoHub.Services.MockService;

#if ANDROID
using Android.Views.InputMethods;
using Android.Content;
using Android.App;
using Android.Views;
#elif IOS
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
                 
                 Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("NoUnderline", (handler, view) =>
                 {
                     handler.PlatformView.Background = null;
                 });

                 Microsoft.Maui.Handlers.PageHandler.Mapper.AppendToMapping("HideKeyboardOnTap", (handler, view) =>
                 {
                     var context = handler.MauiContext.Context;
                     var imm = (InputMethodManager)context.GetSystemService(Context.InputMethodService);

                     handler.PlatformView.Touch += (s, e) =>
                     {
                         if (e.Event.Action == MotionEventActions.Down)
                         {
                             var activity = context as Activity;
                             var currentFocus = activity?.CurrentFocus;
                             if (currentFocus != null)
                             {
                                 imm.HideSoftInputFromWindow(currentFocus.WindowToken, HideSoftInputFlags.None);
                                 currentFocus.ClearFocus();
                             }
                         }
                     };
                });
#endif

#if IOS
                   
                    Microsoft.Maui.Handlers.PageHandler.Mapper.AppendToMapping("HideKeyboardOnTap", (handler, view) =>
                    {
                        var tapGesture = new UITapGestureRecognizer(() => handler.PlatformView.EndEditing(true));
                        tapGesture.CancelsTouchesInView = false;
                        handler.PlatformView.AddGestureRecognizer(tapGesture);
                    });
#endif
                });

            builder.Services.AddTransientWithShellRoute<LoginPage, LoginPageViewModel>("LoginPage");
            builder.Services.AddTransientWithShellRoute<RegisterPage, RegisterPageViewModel>("RegisterPage");
            builder.Services.AddTransientWithShellRoute<CatalogPage, CatalogPageViewModel>("CatalogPage");
            builder.Services.AddTransientWithShellRoute<DetailsPage, DetailsPageViewModel>("DetailsPage");
            builder.Services.AddSingleton<INavigationService, NavigationService>();
            builder.Services.AddSingleton<IMockService, MockService>();
#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}

