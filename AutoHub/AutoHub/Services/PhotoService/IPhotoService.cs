namespace AutoHub.Services.PhotoService
{
    public interface IPhotoService
    {
        Task<IEnumerable<FileResult>> PickPhotosFromGalleryAsync(int maxCount = 12);
        Task<FileResult?> TakePhotoFromCameraAsync();
    }
}
