namespace WinFormsClient.Repositorio;

public class PersonaRepository : IPersonaRepository
{
    private readonly Repository Repository;
    public PersonaRepository(IDbContextFactory<Repository> repository) => Repository = repository.CreateDbContext();

    public async Task<IEnumerable<Persona>> GetPersonsAsync()
    {
        return await Repository.Set<Persona>().ToListAsync();
    }
}