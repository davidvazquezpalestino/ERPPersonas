namespace WinFormsClient.Abstracciones;

public interface IPersonaRepository
{
    Task UpdatePersonAsync(IEnumerable<PersonaCommand>  personas);
}