namespace WinFormsClient.Abstracciones;

public interface ICreditoRepository
{
    Task<IEnumerable<Credito>> GetCreditosAsync(Expression<Func<Credito, bool>> expression);
}