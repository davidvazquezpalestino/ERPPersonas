namespace WinFormsClient.Abstracciones;

public interface ISucursalRepository
{
    Task<IEnumerable<Sucursal>> GetSucursalesAsync(Expression<Func<Sucursal, bool>> expression);
}