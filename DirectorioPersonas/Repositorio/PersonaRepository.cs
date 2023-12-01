namespace WinFormsClient.Repositorio;

public class PersonaRepository(IDbContextFactory<Repository> repository) : IPersonaRepository
{
    private readonly Repository Repository = repository.CreateDbContext();

    public async Task<IEnumerable<Persona>> GetPersonsAsync()
    {
        return await Repository.Set<Persona>().ToListAsync();
    }

    public async Task UpdatePersonAsync(IEnumerable<Persona> personas)
    {
        Repository.UpdateRange(personas);
        await Repository.SaveChangesAsync();
    }
}