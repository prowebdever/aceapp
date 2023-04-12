using AceApp.Data;
using Azure.Storage.Blobs;
using Microsoft.Extensions.Options;

namespace AceApp.Services
{
    public class BlobStorageService : IBlobStorageService
    {
        private readonly AppSettings _appsettings;

        public BlobStorageService(IOptions<AppSettings> appsettings)
        {
            _appsettings = appsettings.Value;

        }
        public async Task<string> UploadAvatarAsync(IFormFile file, string fileName)
        {
            BlobServiceClient blobServiceClient = new BlobServiceClient(_appsettings.AzureBlobConnectionString);
            BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient(_appsettings.AzureBlobContainerName);
            containerClient.CreateIfNotExists();

            BlobClient blobClient = containerClient.GetBlobClient(fileName);
            var res = await blobClient.UploadAsync(file.OpenReadStream());
            return await Task.FromResult(blobClient.Uri.AbsoluteUri);

        }
        public void Dispose()
        {

        }
    }
}
