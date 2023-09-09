using InventarioPokemon.Forms;
using InventarioPokemon.Models;
using InventarioPokemon.Models.UsuarioLoginERegistrar;
using InventarioPokemon.Services.ServicoDeAutenticacao;
using InventarioPokemon.Services.BdConexao;
using Npgsql;
using System.Configuration;

namespace InventarioPokemon
{
    public partial class FormMenuLogin : Form
    {
        private string _conexaoString;
        public FormMenuLogin()
        {
            InitializeComponent();
            btnTestarConexao.Click += new EventHandler(btnTestarConexao_Click);
            _conexaoString = SqlConnectManager.GetConnectionString();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FormTelaUsuario telaUsuario = new();
            string email = txtEmailLogin.Text;
            string senha = txtSenhaLogin.Text;

            AutenticacaoService autenticacaoService = new AutenticacaoService(_conexaoString);
            autenticacaoService.AutenticarUsuario(email, senha, this);
        }

        private void btnTestarConexao_Click(object sender, EventArgs e)
        {
            NpgsqlConnection _conectar = SqlConnection.Conecta();

            if (_conectar != null)
            {
                lblConexao.Text = "Conectado";
                lblConexao.ForeColor = Color.Green;
                _conectar.Close();
            }
            else
            {
                lblConexao.Text = "Desconectado";
                lblConexao.ForeColor = Color.Red;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            FormMenuRegistrar menuRegistrar = new FormMenuRegistrar();
            this.Hide();
            menuRegistrar.ShowDialog();
            this.Show();
        }
    }
}