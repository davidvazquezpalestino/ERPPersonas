
namespace WinFormsClient.Repositorio;
public class DomicilioRepository(Repository repository) : IDomicilioRepository
{
    public async Task CreateAsync(Domicilios domicilios)
    {
        await repository.Set<Domicilios>().AddAsync(domicilios);
        await repository.SaveChangesAsync();
    }

    public async Task UpdateAsync(Domicilios domicilios)
    {
        repository.Set<Domicilios>().Update(domicilios);
        await repository.SaveChangesAsync();
    }

    public async Task<ICollection<Domicilios>> GetDomiciliosAsync(Expression<Func<Domicilios, bool>> expression)
    {
        return await repository.Set<Domicilios>()
                .Include(domicilio => domicilio.TipoDetalle)
                .Include(domicilio => domicilio.EstatusActual)
                .Where(expression)
                .OrderBy(domicilio => domicilio.IdDomicilio)
                .ToListAsync();
    }
}