namespace WinFormsClient.Repositorio;
internal class CreditoRepository(IDbContextFactory<RepositoryQuery> query) : ICreditoRepository
{
    public async Task<IEnumerable<Credito>> GetCreditosAsync(Expression<Func<Credito, bool>> expression)
    {
        using (RepositoryQuery repository = await query.CreateDbContextAsync())
        {
            List<Credito> creditos = await repository.Set<Credito>()
                                                    .Include(socio => socio.Socio)
                                                    .ThenInclude(socio => socio.Persona)
                                                    .ThenInclude(persona => persona.Email)
                                                    .Include(credito => credito.Socio.Sucursal)
                                                    .Include(credito => credito.TipoCredito)
                                                    .Where(expression)
                                                    .AsNoTracking()
                                                    .ToListAsync();
            return creditos;
        }
    }
}