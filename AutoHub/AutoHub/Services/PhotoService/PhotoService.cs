namespace AutoHub.Services.PhotoService
{
    public class PhotoService : IPhotoService
    {
        public async Task<IEnumerable<FileResult>> PickPhotosFromGalleryAsync(int maxCount = 12)
        {
            try
            {
                var status = await Permissions.CheckStatusAsync<Permissions.Photos>();
                if (status != PermissionStatus.Granted)
                {
                    status = await Permissions.RequestAsync<Permissions.Photos>();
                    if (status != PermissionStatus.Granted)
                    {
                        return Enumerable.Empty<FileResult>();
                    }
                }

                var photos = await MediaPicker.PickPhotosAsync(new MediaPickerOptions
                {
                    Title = $"Please select photos (up to {maxCount})"
                });

                if (photos == null)
                {
                    return Enumerable.Empty<FileResult>();
                }

                return photos.Take(maxCount);
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to pick photos: {ex.Message}", ex);
            }
        }
        
        public async Task<FileResult?> TakePhotoFromCameraAsync()
        {
            try
            {
                var status = await Permissions.CheckStatusAsync<Permissions.Camera>();
                if (status != PermissionStatus.Granted)
                {
                    status = await Permissions.RequestAsync<Permissions.Camera>();
                    if (status != PermissionStatus.Granted)
                    {
                        throw new Exception("Camera permission was denied. Please grant camera permission in app settings.");
                    }
                }

                var photo = await MediaPicker.CapturePhotoAsync(new MediaPickerOptions
                {
                    Title = "Please take a photo"
                });

                return photo;
            }
            catch (PermissionException pex)
            {
                throw new Exception("Camera permission was denied. Please grant camera permission in app settings.", pex);
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to take photo: {ex.Message}", ex);
            }
        }
    }
}
