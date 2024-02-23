using System.IO;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;

namespace WinFormsClient.Repositorio;

public class FileStoreAzure(IConfiguration configuration) : IFileStore
{
    private readonly string ConnectionString = configuration.GetConnectionString("AzureStore");
    public async Task<string> StoreAsync(string container, IFormFile file)
    {
        BlobContainerClient client = new BlobContainerClient(ConnectionString, container);
        await client.CreateIfNotExistsAsync();
        await client.SetAccessPolicyAsync(PublicAccessType.Blob);

        string fileName = Path.Combine("Constancia de Situación Fiscal", file.FileName);
        BlobClient blobClient = client.GetBlobClient(fileName);

        BlobHttpHeaders blobHttpHeaders = new BlobHttpHeaders { ContentType = file.ContentType };
        await blobClient.UploadAsync(file.OpenReadStream(), blobHttpHeaders);

        return blobClient.Uri.ToString();
    }
}