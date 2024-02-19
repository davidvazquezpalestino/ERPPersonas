namespace WinFormsClient.Repositorio;

public class PersonaRepository(IDbContextFactory<RepositoryQuery> query, IDbContextFactory<RepositoryCommand> command) : IPersonaRepository
{
    private readonly RepositoryQuery Query = query.CreateDbContext();

    public async Task<IEnumerable<Persona>> GetPersonsAsync()
    {
        using (RepositoryQuery repository = await query.CreateDbContextAsync())
        {
            return await Query.Set<Persona>().ToListAsync();
        }
    }

    public async Task UpdatePersonAsync(IEnumerable<PersonaCommand> personas)
    {
        using (RepositoryCommand repository = await command.CreateDbContextAsync())
        {
            repository.UpdateRange(personas);
            await repository.SaveChangesAsync();
        }
    }
}