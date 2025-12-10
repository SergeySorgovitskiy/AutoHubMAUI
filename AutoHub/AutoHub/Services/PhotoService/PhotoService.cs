using Microsoft.Maui.Storage;
using Microsoft.Maui.Media;

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

#if IOS
                var copiedFiles = new List<FileResult>();
                foreach (var photo in photos.Take(maxCount))
                {
                    if (photo != null)
                    {
                        var copiedFile = await CopyToLocalStorageAsync(photo);
                        if (copiedFile != null)
                        {
                            copiedFiles.Add(copiedFile);
                        }
                    }
                }
                return copiedFiles;
#else
                return photos.Take(maxCount);
#endif
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

                if (photo == null)
                {
                    return null;
                }

#if IOS
                return await CopyToLocalStorageAsync(photo);
#else
                return photo;
#endif
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

#if IOS
        private async Task<FileResult?> CopyToLocalStorageAsync(FileResult file)
        {
            try
            {
                if (file == null) return null;

                var localAppData = FileSystem.AppDataDirectory;
                var fileName = $"{Guid.NewGuid()}{Path.GetExtension(file.FileName)}";
                var targetPath = Path.Combine(localAppData, fileName);

                using (var sourceStream = await file.OpenReadAsync())
                using (var targetStream = File.Create(targetPath))
                {
                    await sourceStream.CopyToAsync(targetStream);
                }

                return new FileResult(targetPath, file.ContentType);
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to copy file: {ex.Message}", ex);
            }
        }
#endif
    }
}
