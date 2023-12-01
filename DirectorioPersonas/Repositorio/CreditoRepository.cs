namespace WinFormsClient.Repositorio;

public class CreditoRepository(IDbContextFactory<Repository> repository) : ICreditoRepository
{
    private readonly Repository Repository = repository.CreateDbContext();

    public async Task<IEnumerable<Credito>> GetCreditosAsync()
    {
        return await Repository.Set<Credito>()
            .Include(socio => socio.Socio)
            .ThenInclude(socio => socio.Persona)
            .Include(credito => credito.Socio.Sucursal)
            .Include(credito => credito.TipoCredito)
            .Where(credito => credito.IdEstatus == 1 && credito.IdTipoDProducto == 143)
            .ToListAsync();
    }
}