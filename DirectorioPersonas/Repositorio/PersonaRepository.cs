namespace WinFormsClient.Repositorio;

public class PersonaRepository( IDbContextFactory<RepositoryCommand> command) : IPersonaRepository
{
    public async Task UpdatePersonAsync(IEnumerable<PersonaCommand> personas)
    {
        using (RepositoryCommand repository = await command.CreateDbContextAsync())
        {
            await repository.BulkUpdateAsync(personas);
        }
    }
}