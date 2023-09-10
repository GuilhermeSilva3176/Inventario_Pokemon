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
            IDUsuario infoUsuario = new();

            string email = txtEmailLogin.Text;
            string senha = txtSenhaLogin.Text;
            infoUsuario.usarID(email, senha);
            AutenticacaoService aut = new();
            aut.AutenticarUsuario(email, senha, this);
            FormTelaUsuario telaUsuario = new();
            telaUsuario.UsuarioID = infoUsuario.usarID(email,senha);
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