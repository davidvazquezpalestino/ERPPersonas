namespace WinFormsClient.Repositorio;

internal class SucursalRepository(IDbContextFactory<RepositoryQuery> repository) : ISucursalRepository
{
    private readonly RepositoryQuery Repository = repository.CreateDbContext();
    public async Task<IEnumerable<Sucursal>> GetSucursalesAsync(Expression<Func<Sucursal, bool>> expression)
    {
        return await Repository.Set<Sucursal>()
            .Where(expression)
            .OrderBy(sucursal => sucursal.Descripcion)
            .ToListAsync();
    }
}