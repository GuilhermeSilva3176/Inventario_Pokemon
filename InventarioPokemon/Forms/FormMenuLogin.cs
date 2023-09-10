using InventarioPokemon.Forms;
using InventarioPokemon.Services.ServicoDeAutenticacao;
using InventarioPokemon.Models.UsuarioModels.UsuarioConfigs;
using InventarioPokemon.Models.UsuarioModels;

namespace InventarioPokemon
{
    public partial class FormMenuLogin : Form
    {

        private UserModel user;
        public FormMenuLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string email = txtEmailLogin.Text;
            string senha = txtSenhaLogin.Text;

            try
            {
                
                AutenticacaoService aut = new();
                int usuarioID = aut.AutenticarUsuario(email, senha, this);
                if (usuarioID > 0)
                {
                    FormTelaUsuario telaUsuario = new();
                    telaUsuario.UsuarioID = usuarioID;
                    this.Hide();
                    telaUsuario.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro inesperado: {ex}");
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            FormMenuRegistrar menuRegistrar = new FormMenuRegistrar();
            this.Hide();
            menuRegistrar.Show();
        }

        private void FormMenuLogin_Load(object sender, EventArgs e)
        {

        }
    }
}