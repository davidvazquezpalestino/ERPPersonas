namespace WinFormsClient.Repositorio;

internal class CreditoRepository(IDbContextFactory<Repository> repository) : ICreditoRepository
{
    private readonly Repository Repository = repository.CreateDbContext();

    public async Task<IEnumerable<Credito>> GetCreditosAsync(Expression<Func<Credito, bool>> expression)
    {
        return await Repository.Set<Credito>()
            .Include(socio => socio.Socio)
            .ThenInclude(socio => socio.Persona)
            .ThenInclude(persona => persona.Email)
            .Include(credito => credito.Socio.Sucursal)
            .Include(credito => credito.TipoCredito)
            
            .Where(expression)
            .ToListAsync();
    }
}