
namespace WinFormsClient.Entidades
{
    public class Domicilios
    {
        public int IdDomicilio { get; set; }
        public int IdRel { get; set; }
        public int Orden { get; set; }
        public int IdTipoD { get; set; }
        public TipoDetalle TipoDetalle { get; set; }
        public string Descripcion { get; set; }
        public string Calle { get; set; }
        public string? NumeroExterior { get; set; }
        public string? NumeroInterior { get; set; }
        public string Calles { get; set; }
        public string CodigoPostal { get; set; }
        public string Asentamiento { get; set; }
        public string Ciudad { get; set; }
        public string Municipio { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        public int IdEstatusActual { get; set; }
        public EstatusActual? EstatusActual { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public int? IdControl { get; set; }
        public string? Referencia { get; set; }
        public int IdTipoDzona { get; set; }
        public string? DiasAtencion { get; set; }
        public DateTime HoraLocalizacionInicial { get; set; }
        public DateTime HoraLocalizacionFinal { get; set; }
        public string Domicilio { get; set; }
        public override string ToString() => Descripcion;
    }
}
