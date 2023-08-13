namespace WinFormsClient
{
    public partial class FormPersonas : XtraForm
    {
        private readonly ICreditoRepository CreditoRepository;
        private readonly IServiceProvider Provider;

        public FormPersonas(IPersonaRepository personaRepository,
            ICreditoRepository creditoRepository, IServiceProvider provider)
        {
            CreditoRepository = creditoRepository;
            Provider = provider;
            InitializeComponent();

            //IdRelDomicilios
        }

        private async void FormPersonas_Load(object sender, System.EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            IEnumerable<Credito> creditos = await CreditoRepository.GetCreditosAsync();
            gridControlCuentas.SetItems(creditos);

            this.Cursor = Cursors.Default;
        }

        private void gridControlCuentas_DoubleClick(object sender, EventArgs e)
        {
            Credito credito = (Credito)gridViewCuentas.GetFocusedRow();

            int relDomicilios = credito.Socio.Persona.IdRelDomicilios;

            FormDomicilios formDomicilios = Provider.GetRequiredService<FormDomicilios>();
            formDomicilios.SetRelDomicilios(relDomicilios);
            formDomicilios.Show();
        }
    }
}
