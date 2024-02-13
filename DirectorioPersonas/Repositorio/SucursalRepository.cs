namespace WinFormsClient.Repositorio;

internal class SucursalRepository(IDbContextFactory<Repository> repository) : ISucursalRepository
{
    private readonly Repository Repository = repository.CreateDbContext();
    public async Task<IEnumerable<Sucursal>> GetSucursalesAsync(Expression<Func<Sucursal, bool>> expression)
    {
        return await Repository.Set<Sucursal>()
            .Where(expression)
            .OrderBy(sucursal => sucursal.Descripcion)
            .ToListAsync();
    }
}