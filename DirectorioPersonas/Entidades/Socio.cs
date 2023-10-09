namespace WinFormsClient.Entidades
{
    public class Socio
    {
        public int IdSocio { get; set; }
        public int IdPersona { get; set; }
        public string Codigo { get; set; }
        public int IdSucursal { get; set; }
        public Persona Persona { get; set; }
        public Sucursal Sucursal { get; set; }

    }
}
