namespace WinFormsClient
{
    public partial class FormLogin : Form
    {
        private readonly IMessageBox<DialogResult> MessageBox;
        private readonly ISecurityIntelix SecurityIntelix;
        private readonly IUserRepository UserRepository;
        private readonly ISucursalRepository SucursalRepository;
        private readonly IServiceProvider Provider;

        public FormLogin(IMessageBox<DialogResult> messageBox,
            ISecurityIntelix securityIntelix,
            IUserRepository userRepository,
            ISucursalRepository sucursalRepository,
            IServiceProvider provider)
        {
            MessageBox = messageBox;
            SecurityIntelix = securityIntelix;
            UserRepository = userRepository;
            SucursalRepository = sucursalRepository;
            Provider = provider;
            InitializeComponent();
            btnSalir.Click += (sender, e) => Close();
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (DatosValidos())
                {
                    User user = await UserRepository.GetUserAsync(txtUsurio.GetText());
                    if (user is not null)
                    {
                        string cadena = SecurityIntelix.DescrifrarCadena(user.Llave);
                        string[] camposLlave = cadena.Split(["@@"], StringSplitOptions.RemoveEmptyEntries);

                        if (camposLlave[7] == txtContraseña.GetText().Trim())
                        {
                            FormPersonas formPersonas = Provider.GetRequiredService<FormPersonas>();
                            formPersonas.SucursalID = ComboBoxSucursal.Principal<int>();
                            formPersonas.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.ShowError("Usuario o contraseña incorrectos");
                        }
                    }
                    else
                    {
                        MessageBox.ShowError("Usuario o contraseña incorrectos");
                    }
                }
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception.Message);
                MessageBox.ShowError(exception);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        private bool DatosValidos()
        {
            if (string.IsNullOrEmpty(txtUsurio.Text.Trim()))
            {
                MessageBox.ShowError("Ingrese el Usuario.");
                txtUsurio.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtContraseña.Text.Trim()))
            {
                MessageBox.ShowError("Ingrese la Contraseña.");
                txtContraseña.Focus();
                return false;
            }
            if (ComboBoxSucursal.Principal<int>() == 0)
            {
                MessageBox.ShowError("Debe de seleccionar una sucursal");
                ComboBoxSucursal.Focus();
                return false;
            }

            return true;
        }

        private async void FormLogin_Load(object sender, EventArgs e)
        {
            IEnumerable<Sucursal> sucursales = await SucursalRepository
                .GetSucursalesAsync(sucursal => new[] { 0, 1 }.Contains(sucursal.IdSucursal) == false);

            ComboBoxSucursal.SetItems(sucursales);
        }
    }
}

