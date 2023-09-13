using InventarioPokemon.Forms;
using InventarioPokemon.Models.UsuarioModels;

namespace InventarioPokemon
{
    public partial class FormMenuLogin : Form
    {
        public FormMenuLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string email = txtEmailLogin.Text;
            string senha = txtSenhaLogin.Text;
            FormTelaUsuario fTelaUsuario = new();
            LogarConta lgConta = new();
            try
            {
                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(senha))
                {
                    lblLogar.Text = "Preencha antes de tentar o login";
                }
                
                int id = lgConta.LogarUsuario(email, senha);
                
                if(id > 0)
                {
                    this.Hide();
                    fTelaUsuario.Show();
                }
                else
                {
                    lblLogar.Text = "Email ou Senha Errados";
                    lblLogar.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro inesperado: {ex}");
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            FormMenuRegistrar menuRegistrar = new();
            this.Hide();
            menuRegistrar.Show();
        }

        private void FormMenuLogin_Load(object sender, EventArgs e)
        {

        }
    }
}