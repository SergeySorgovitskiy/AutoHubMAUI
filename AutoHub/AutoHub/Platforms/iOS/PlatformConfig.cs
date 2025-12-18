#if IOS
using UIKit;
using Microsoft.Maui.Handlers;

namespace AutoHub.Platforms.iOS
{
    public static class PlatformConfig
    {
        public static void ConfigurePlatform()
        {
            SearchBarHandler.Mapper.AppendToMapping("NoBorder", (handler, view) =>
            {
                if (handler.PlatformView is UISearchBar searchBar)
                {

                    searchBar.BackgroundImage = new UIKit.UIImage();
                    searchBar.BarTintColor = UIKit.UIColor.Clear;
                    searchBar.SearchBarStyle = UISearchBarStyle.Minimal;

                    searchBar.Layer.BorderWidth = 0;
                    searchBar.Layer.BorderColor = UIKit.UIColor.Clear.CGColor;

                    foreach (var subview in searchBar.Subviews)
                    {
                        foreach (var subSubview in subview.Subviews)
                        {
                            if (subSubview is UITextField textField)
                            {
                                textField.BorderStyle = UITextBorderStyle.None;
                                textField.BackgroundColor = UIKit.UIColor.Clear;
                                textField.Layer.BorderWidth = 0;
                            }
                        }
                    }
                }
            });
        }
    }
}
#endif