using Microsoft.AspNetCore.Http.Internal;
using System.IO;

namespace WinFormsClient
{
    public partial class FormPersonas : XtraForm
    {
        private readonly IPersonaRepository PersonaRepository;
        private readonly ICreditoRepository CreditoRepository;
        private readonly IMessageBox<DialogResult> MessageBox;
        private readonly ISucursalRepository SucursalRepository;
        private readonly IFileStore FileStore;
        public int SucursalID;
        public int UserID { get; set; }

        readonly RepositoryItemLookUpEdit RepositoryCombo = new RepositoryItemLookUpEdit();

        private static readonly int[] EstatusCreditos = [1, 53, 73];

        public FormPersonas(IPersonaRepository personaRepository,
            ICreditoRepository creditoRepository,
            ISucursalRepository sucursalRepository,
            IFileStore fileStore,
            IMessageBox<DialogResult> messageBox)
        {
            PersonaRepository = personaRepository;
            CreditoRepository = creditoRepository;
            SucursalRepository = sucursalRepository;
            FileStore = fileStore;
            MessageBox = messageBox;
            InitializeComponent();

            gridViewCuentas.CellValueChanging += GridViewCuentas_CellValueChanging;
            ComboBoxSucursales.SelectedValueChanged += LComboBoxSucursales_SelectedValueChanged;
           
        }

        private async void FormPersonas_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                FileInfo fileInfo = new FileInfo(openFileDialog.FileName);

                if (fileInfo.Extension.ToLower() != ".pdf")
                {
                    throw new InvalidOperationException("El archivo no es un PDF.");
                }

                // Leer el contenido del archivo PDF en un MemoryStream
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (FileStream fileStream = fileInfo.OpenRead())
                    {
                        await fileStream.CopyToAsync(memoryStream);
                    }
                    FormFile formFile = new FormFile(
                        baseStream: memoryStream,
                        baseStreamOffset: 0,
                        length: memoryStream.Length,
                        name: fileInfo.Name,
                        fileName: fileInfo.Name
                    )
                    {
                        Headers = new HeaderDictionary(),
                        ContentType = "application/pdf"
                    };

                    string url = await FileStore.StoreAsync("cajazongolica", formFile);
                }
            }
        }

        private async void LComboBoxSucursales_SelectedValueChanged(object sender, EventArgs e)
        {
            IEnumerable<Credito> creditos = await GetCreditosAsync();

            gridControlCuentas.SetItems(creditos);

            gridViewCuentas.BestFitColumns();
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
            CheckForIllegalCrossThreadCalls = false;
            ComboBoxSucursales.SelectedValueChanged -= LComboBoxSucursales_SelectedValueChanged;
            await ListarCreditos();
            ComboBoxSucursales.SelectedValueChanged += LComboBoxSucursales_SelectedValueChanged;
            RepositoryCombo.TextEditStyle = TextEditStyles.DisableTextEditor;
            ComboBoxSucursales.ReadOnly = UserID != -1;
        }

        private async Task ListarCreditos()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                ButtonQuery.Enabled = false;

                ICollection<CatalogoRegimenFiscal> regimenFiscals = new List<CatalogoRegimenFiscal>();
                IEnumerable<Credito> creditos = new List<Credito>();

                List<Sucursal> sucursales = (List<Sucursal>)await SucursalRepository.GetSucursalesAsync(sucursal =>
                    new[] { 0, 1 }.Contains(sucursal.IdSucursal) == false);

                ComboBoxSucursales.SetItems(sucursales);
                ComboBoxSucursales.SetItem(SucursalID);

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
                    List<PersonaCommand> personas = creditos
                        .Where(credito => credito.CambioValor)
                        .Select(credito => new PersonaCommand()
                        {
                            IdPersona = credito.Socio.Persona.IdPersona,
                            CodigoPostal = credito.Socio.Persona.CodigoPostal,
                            RegimenFiscal = credito.Socio.Persona.RegimenFiscal
                        }).ToList();

                    if (personas.Count > 0)
                    {
                        await Task.Run(async () =>
                        {
                            await PersonaRepository.UpdatePersonAsync(personas);
                            MessageBox.ShowMessage("Los cambios se guardarón");

                            await Task.Run(() =>
                            {
                                gridControlCuentas.Invoke(new Action(async () =>
                                {
                                    gridControlCuentas.SetItems(await GetCreditosAsync());
                                }));
                            });
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

            ComboBoxSucursales.Properties.ReadOnly = true;

            IEnumerable<Credito> creditos = await CreditoRepository.GetCreditosAsync(credito =>
                EstatusCreditos.Contains(credito.IdEstatus) &&
                credito.IdTipoDProducto == 143 && (credito.Socio.Persona.EsPersonaMoral == false && credito.ExentaIVA || credito.Socio.Persona.EsPersonaMoral) &&
                credito.IdSucursal == ComboBoxSucursales.Principal<int>());

            ComboBoxSucursales.Properties.ReadOnly = false;

            return creditos;
        }

        private async void ButtonQuery_Click(object sender, EventArgs e) => await ListarCreditos();

        public async Task<ICollection<CatalogoRegimenFiscal>> GetRegimenFiscalAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync("https://integratepluscatalogossatapi.azurewebsites.net/api/RegimenFiscal/GetRegimenFiscalAsync");

                if (response.IsSuccessStatusCode)
                {
                    string responseData = await response.Content.ReadAsStringAsync();

                    return JsonSerializer.Deserialize<ICollection<CatalogoRegimenFiscal>>(responseData, new JsonSerializerOptions(JsonSerializerDefaults.Web));
                }
            }

            return new List<CatalogoRegimenFiscal>();
        }

        private void FormPersonas_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}



public class CatalogoRegimenFiscal
{
    public string RegimenFiscal { get; set; }
    public string Descripcion { get; set; }
    public override string ToString() => Descripcion;

}