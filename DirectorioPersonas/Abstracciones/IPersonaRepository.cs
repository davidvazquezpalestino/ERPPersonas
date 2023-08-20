namespace WinFormsClient.Abstracciones;

public interface IPersonaRepository
{
    Task<IEnumerable<Persona>> GetPersonsAsync();
    Task UpdatePersonAsync(IEnumerable<Persona>  personas);
}