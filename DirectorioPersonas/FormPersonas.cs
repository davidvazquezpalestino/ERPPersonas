namespace WinFormsClient
{
    public partial class FormPersonas : XtraForm
    {
        private readonly IPersonaRepository PersonaRepository;
        private readonly ICreditoRepository CreditoRepository;
        private readonly IMessageBox<DialogResult> MessageBox;

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

        private void GridViewCuentas_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
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
        }

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

                    await Task.WhenAll(
                        Task.Run(async () =>
                        {
                            await PersonaRepository.UpdatePersonAsync(personas);
                            MessageBox.ShowMessage("Los cambios se guardarón");
                        }),
                        Task.Run(() => gridControlCuentas
                            .Invoke(new Action(async () => gridControlCuentas
                                .SetItems(await CreditoRepository
                                    .GetCreditosAsync())))));
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
