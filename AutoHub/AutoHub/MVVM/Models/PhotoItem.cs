using CommunityToolkit.Mvvm.ComponentModel;

namespace AutoHub.MVVM.Models
{
    public partial class PhotoItem : ObservableObject
    {
        [ObservableProperty]
        private ImageSource? _imageSource;

        [ObservableProperty]
        private string _filePath;

        public PhotoItem(ImageSource imageSource, string filePath)
        {
            ImageSource = imageSource;
            FilePath = filePath;
        }
    }
}


