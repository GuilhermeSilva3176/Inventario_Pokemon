using InventarioPokemon.Forms;
using InventarioPokemon.Services.ServicoDeAutenticacao;

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
            
            try
            {
                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(senha))
                {
                    lblLogar.Text = "Preencha antes de tentar o login";
                }
                AutenticacaoService aut = new();
                int id = aut.AutenticarUsuario(email, senha);
                
                if(id > 0)
                {
                    this.Hide();
                    fTelaUsuario.Email = email;
                    fTelaUsuario.Senha = senha;
                    fTelaUsuario.Show();
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