namespace WinFormsClient.Abstracciones;

public interface ISocioRepository
{
    Task<IEnumerable<Socio>> GetSociosAsync();
}