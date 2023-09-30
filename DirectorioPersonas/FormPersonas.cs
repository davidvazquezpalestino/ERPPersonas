using CoreMessageBox.Abstracciones;

namespace WinFormsClient
{
    public partial class FormPersonas : XtraForm
    {
        private readonly IPersonaRepository PersonaRepository;
        private readonly ICreditoRepository CreditoRepository;
        private readonly IMessageBox<DialogResult> MessageBox;
        private readonly IServiceProvider Provider;

        public FormPersonas(IPersonaRepository personaRepository,
            ICreditoRepository creditoRepository,
            IMessageBox<DialogResult> messageBox,
            IServiceProvider provider)
        {
            PersonaRepository = personaRepository;
            CreditoRepository = creditoRepository;
            MessageBox = messageBox;
            Provider = provider;
            InitializeComponent();
        }

        private async void FormPersonas_Load(object sender, System.EventArgs e) => await ListarCreditos();

        private async Task ListarCreditos()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                ButtonQuery.Enabled = false;
                IEnumerable<Credito> creditos = await CreditoRepository.GetCreditosAsync();
                gridControlCuentas.SetItems(creditos);
            }
            finally
            {
                ButtonQuery.Enabled = true;
                this.Cursor = Cursors.Default;
            }
        }

        private void gridControlCuentas_DoubleClick(object sender, EventArgs e)
        {
            Credito credito = (Credito)gridViewCuentas.GetFocusedRow();

            int relDomicilios = credito.Socio.Persona.IdRelDomicilios;

            FormDomicilios formDomicilios = Provider.GetRequiredService<FormDomicilios>();
            formDomicilios.SetRelDomicilios(relDomicilios);
            formDomicilios.Show();
        }

        private async void ButtonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                IEnumerable<Credito> creditos = (IEnumerable<Credito>)gridControlCuentas.DataSource;
                if (creditos is not null)
                {
                    List<Persona> personas = creditos.Where(credito => string.IsNullOrEmpty(credito.Socio.Persona.CodigoPostal) == false ||
                                                                       string.IsNullOrEmpty(credito.Socio.Persona.RegimenFiscal) == false)
                        .Select(credito => credito.Socio.Persona).ToList();

                    await PersonaRepository.UpdatePersonAsync(personas);
                    MessageBox.ShowMessage("Los cambios se guardarón");
                }
            }
            catch (Exception exception)
            {
                MessageBox.ShowError(exception);
            }
        }

        private async void ButtonQuery_Click(object sender, EventArgs e) => await ListarCreditos();
    }
}
