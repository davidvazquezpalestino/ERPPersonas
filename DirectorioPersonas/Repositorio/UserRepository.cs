namespace WinFormsClient.Repositorio;

public class UserRepository(RepositoryQuery repository) : IUserRepository
{
    public async Task<User> GetUserAsync(string username)
    {
        User user = await repository.Set<User>().FirstOrDefaultAsync(user => user.Usuario == username);
        if (user is null)
        {
            return new User();
        }
        return user;
    }
}