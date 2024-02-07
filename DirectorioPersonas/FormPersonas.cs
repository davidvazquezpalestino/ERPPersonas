namespace WinFormsClient
{
    public partial class FormPersonas : XtraForm
    {
        private readonly IPersonaRepository PersonaRepository;
        private readonly ICreditoRepository CreditoRepository;
        private readonly IMessageBox<DialogResult> MessageBox;
        public int SucursalID;

        readonly RepositoryItemLookUpEdit RepositoryCombo = new RepositoryItemLookUpEdit();
        private static readonly int[] EstatusCreditos = [1, 53, 73];

        public FormPersonas(IPersonaRepository personaRepository,
            ICreditoRepository creditoRepository,
            IMessageBox<DialogResult> messageBox)
        {
            PersonaRepository = personaRepository;
            CreditoRepository = creditoRepository;
            MessageBox = messageBox;
            InitializeComponent();

            gridViewCuentas.CellValueChanging += GridViewCuentas_CellValueChanging;
        }

        private void GridViewCuentas_CellValueChanging(object sender,
            DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            Credito row = (Credito)gridViewCuentas.GetRow(e.RowHandle);
            if (row != null)
            {
                row.CambioValor = true;
            }
        }

        private async void FormPersonas_Load(object sender, System.EventArgs e)
        {
            await ListarCreditos();
            RepositoryCombo.TextEditStyle = TextEditStyles.DisableTextEditor;
        }

        private async Task ListarCreditos()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                ButtonQuery.Enabled = false;

                ICollection<CatalogoRegimenFiscal> regimenFiscals = new List<CatalogoRegimenFiscal>();
                IEnumerable<Credito> creditos = new List<Credito>();

                await Task.WhenAll(
                    Task.Run(async () => regimenFiscals = await GetRegimenFiscalAsync()),
                    Task.Run(async () => creditos = await GetCreditosAsync()));

                RepositoryCombo.DataSource = regimenFiscals;

                gridControlCuentas.RepositoryItems.Add(RepositoryCombo);
                gridViewCuentas.Columns[colRegimenFiscal.FieldName].ColumnEdit = RepositoryCombo;

                RepositoryCombo.DisplayMember = "Descripcion";
                RepositoryCombo.ValueMember = "RegimenFiscal";

                gridControlCuentas.SetItems(creditos);
                RepositoryCombo.NullText = "";

                RepositoryCombo.PopulateColumns();
                RepositoryCombo.BestFit();

                gridViewCuentas.BestFitColumns();
            }
            finally
            {
                ButtonQuery.Enabled = true;
                this.Cursor = Cursors.Default;
            }
        }

        private async void ButtonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                IEnumerable<Credito> creditos = (IEnumerable<Credito>)gridControlCuentas.DataSource;
                if (creditos is not null)
                {
                    List<Persona> personas = creditos
                        .Where(credito => credito.CambioValor)
                        .Select(credito => credito.Socio.Persona)
                        .ToList();

                    if (personas.Count > 0)
                    {
                        await Task.Run(async () =>
                        {
                            await PersonaRepository.UpdatePersonAsync(personas);
                            MessageBox.ShowMessage("Los cambios se guardarón");

                            await Task.Run(() => gridControlCuentas.Invoke(new Action(async () => gridControlCuentas.SetItems(await GetCreditosAsync()))));
                        });
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.ShowError(exception);
            }
        }

        private async Task<IEnumerable<Credito>> GetCreditosAsync()
        {
            return await CreditoRepository.GetCreditosAsync(credito => 
                EstatusCreditos.Contains(credito.IdEstatus) &&
                credito.IdTipoDProducto == 143 && (credito.Socio.Persona.EsPersonaMoral == false && credito.ExentaIVA || credito.Socio.Persona.EsPersonaMoral) &&
                credito.IdSucursal == SucursalID);
        }

        private async void ButtonQuery_Click(object sender, EventArgs e) => await ListarCreditos();

        public async Task<ICollection<CatalogoRegimenFiscal>> GetRegimenFiscalAsync()
        {
            using (HttpClient client = new HttpClient())
            {

                HttpResponseMessage response = await client.GetAsync(
                    "https://integratepluscatalogossatapi.azurewebsites.net/api/RegimenFiscal/GetRegimenFiscalAsync");

                if (response.IsSuccessStatusCode)
                {
                    string responseData = await response.Content.ReadAsStringAsync();

                    return JsonSerializer.Deserialize<ICollection<CatalogoRegimenFiscal>>(responseData, new JsonSerializerOptions(JsonSerializerDefaults.Web));
                }
            }

            return new List<CatalogoRegimenFiscal>();
        }
    }
}



public class CatalogoRegimenFiscal
{
    public string RegimenFiscal { get; set; }
    public string Descripcion { get; set; }
    public override string ToString() => Descripcion;

}