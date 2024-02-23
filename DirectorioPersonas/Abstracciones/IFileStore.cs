namespace WinFormsClient.Abstracciones;

public interface IFileStore
{
    Task<string> StoreAsync(string container, IFormFile file);
}