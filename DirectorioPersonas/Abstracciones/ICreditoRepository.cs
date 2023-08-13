namespace WinFormsClient.Abstracciones;

public interface ICreditoRepository
{
    Task<IEnumerable<Credito>> GetCreditosAsync();
}