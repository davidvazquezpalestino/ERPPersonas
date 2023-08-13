
namespace WinFormsClient.Repositorio;

public class SocioRepository : ISocioRepository
{
    private readonly Repository Repository;
    public SocioRepository(IDbContextFactory<Repository> repository) => Repository = repository.CreateDbContext();

    public async Task<IEnumerable<Socio>> GetSociosAsync()
    {
        return await Repository.Set<Socio>()
                                .Include(socio => socio.Persona)
                                .Include(socio => socio.Sucursal)
                                .Where(socio => socio.EsSocioValido )
                                .ToListAsync();

    }
}