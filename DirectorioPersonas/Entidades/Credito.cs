namespace WinFormsClient.Entidades;

public class Credito
{
    public int IdCuenta { get; set; }
    public string Codigo { get; set; }
    public string Descripcion { get; set; }
    public int IdTipoDProducto { get; set; }
    public int IdSocio { get; set; }
    public int IdEstatus { get; set; }
    public Socio Socio { get; set; }
}