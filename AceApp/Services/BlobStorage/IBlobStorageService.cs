namespace AceApp.Services
{
    public interface IBlobStorageService : IDisposable
    {
        Task<string> UploadAvatarAsync(IFormFile file, string fileName);
    }
}
