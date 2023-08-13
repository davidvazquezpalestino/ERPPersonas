namespace WinFormsClient.Repositorio;

public class CreditoRepository : ICreditoRepository
{
    private readonly Repository Repository;
    public CreditoRepository(IDbContextFactory<Repository> repository) => 
        Repository = repository.CreateDbContext();
    public async Task<IEnumerable<Credito>> GetCreditosAsync()
    {
        return await Repository.Set<Credito>()
            .Include(socio => socio.Socio)
            .ThenInclude(socio => socio.Persona)
            .Include(credito => credito.Socio.Sucursal)
            .Where(credito => credito.IdEstatus == 1 && credito.IdTipoDProducto == 143)
            .ToListAsync();
    }
}