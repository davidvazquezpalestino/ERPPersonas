namespace WinFormsClient.Repositorio;

public class UserRepository(Repository repository) : IUserRepository
{
    public async Task<User?> GetUserAsync(string username)
    {
        return await repository.Set<User>().FirstOrDefaultAsync(user => user.Usuario == username);
    }
}