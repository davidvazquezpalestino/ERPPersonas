namespace WinFormsClient.Repositorio;

public class UserRepository : IUserRepository
{
    private readonly Repository Repository;
    public UserRepository(Repository repository)
    {
        Repository = repository;
    }
    public async Task<User?> GetUserAsync(string username)
    {
        return await Repository.Set<User>().FirstOrDefaultAsync(user => user.Usuario == username);
    }
}