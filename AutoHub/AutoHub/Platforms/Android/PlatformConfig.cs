namespace AutoHub.Platforms.Android
{
    public static class PlatformConfig
    {
        public static void ConfigurePlatform()
        {  
            Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("NoUnderline", (handler, view) =>
            {
                handler.PlatformView.Background = null;
            });
        }
    }
}