
namespace WinFormsClient.Repositorio;
public class DomicilioRepository : IDomicilioRepository
{
    private readonly Repository Repository;
    public DomicilioRepository(Repository repository) => Repository = repository;

    public async Task CreateAsync(Domicilios domicilios)
    {
        await Repository.Set<Domicilios>().AddAsync(domicilios);
        await Repository.SaveChangesAsync();
    }

    public async Task UpdateAsync(Domicilios domicilios)
    {
        Repository.Set<Domicilios>().Update(domicilios);
        await Repository.SaveChangesAsync();
    }

    public async Task<ICollection<Domicilios>> GetDomiciliosAsync(Expression<Func<Domicilios, bool>> expression)
    {
        return
            await Repository.Set<Domicilios>().Include(domicilio => domicilio.TipoDetalle)
                .Include(domicilio => domicilio.EstatusActual)
                .Where(expression)
                .OrderBy(domicilio => domicilio.IdDomicilio)
                .ToListAsync();
    }
}