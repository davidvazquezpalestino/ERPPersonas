namespace WinFormsClient.Abstracciones;

public interface IDomicilioRepository
{
    Task CreateAsync(Domicilios domicilios);
    Task UpdateAsync(Domicilios domicilios);
    Task<ICollection<Domicilios>> GetDomiciliosAsync(Expression<Func<Domicilios, bool>> expression);
}