namespace WinFormsClient.Abstracciones;

public interface IUserRepository
{
    Task<User?> GetUserAsync(string username);
}