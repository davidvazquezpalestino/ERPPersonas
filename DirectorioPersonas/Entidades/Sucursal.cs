namespace WinFormsClient.Entidades;

public class Sucursal : IPrincipal<int>
{
    public int IdSucursal { get; set; }
    public string Codigo { get; set; }
    public string Descripcion { get; set; }
    public override string ToString() => Descripcion;

    public int PrincipalID => IdSucursal;
}