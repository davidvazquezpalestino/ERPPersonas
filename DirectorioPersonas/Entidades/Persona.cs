namespace WinFormsClient.Entidades
{
    public class Persona
    {
        public int IdPersona { get; set; }
        public int IdRelDomicilios { get; set; }
        public string? Nombre { get; set; }
        public string? RFC { get; set; }
        public string? Domicilio { get; set; }
        public string? RazonSocial { get; set; }
        public string? RegimenFiscal { get; set; }
        public string? CodigoPostal { get; set; }
        public override string? ToString() => RazonSocial;
    }
}
