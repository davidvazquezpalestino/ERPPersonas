using System.Diagnostics;
using WinFormsClient.Repositorio;

namespace WinFormsClient
{
    public partial class FormLogin : Form
    {
        private readonly IMessageBox<DialogResult> MessageBox;
        private readonly ISecurityIntelix SecurityIntelix;
        private readonly IUserRepository UserRepository;
        private readonly IServiceProvider Provider;

        public FormLogin(IMessageBox<DialogResult> messageBox,
            ISecurityIntelix securityIntelix,
            IUserRepository userRepository,
            IServiceProvider provider)
        {
            MessageBox = messageBox;
            SecurityIntelix = securityIntelix;
            UserRepository = userRepository;
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
                    User? user = await UserRepository.GetUserAsync(txtUsurio.GetText());
                    if (user is not null)
                    {
                        string cadena = SecurityIntelix.DescrifrarCadena(user.Llave);
                        string[] camposLlave = cadena.Split(new[] { "@@" }, StringSplitOptions.RemoveEmptyEntries);

                        if (camposLlave[7] == txtContraseña.GetText().Trim())
                        {

                            Form formPersonas = Provider.GetRequiredService<FormPersonas>();
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

            return true;
        }

    }
}

