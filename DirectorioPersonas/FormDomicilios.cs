using Serilog;

namespace WinFormsClient
{
    public partial class FormDomicilios : XtraForm
    {
        private readonly IDomicilioRepository Repository;
        private readonly IMessageBox<DialogResult> MessageBox;
        private readonly ILogger Logger;

        public FormDomicilios(IDomicilioRepository repository,
            IMessageBox<DialogResult> messageBox, ILogger logger)
        {
            Repository = repository;
            MessageBox = messageBox;
            Logger = logger;
            InitializeComponent();

            
        }

        public async void SetRelDomicilios(int relDomicilio)
        {
            ICollection<Domicilios> domicilios =
                await Repository.GetDomiciliosAsync(
                    domicilio => domicilio.IdRel == relDomicilio && domicilio.EstatusActual!.IdEstatus == 1);

            gridControlDomicilio.SetItems(domicilios);
            gridViewDomicilio.BestFitColumns();

            Logger.Information("Bienvenido!!!!!!!!!!!!!");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Domicilios domicilio = (Domicilios)gridViewDomicilio.GetFocusedRow();
                Repository.UpdateAsync(domicilio);

            }
            catch (Exception exception)
            {
                MessageBox.ShowError(exception);
            }
        }
    }
}
