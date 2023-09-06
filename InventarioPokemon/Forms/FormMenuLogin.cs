using InventarioPokemon.Models;
using InventarioPokemon.Services;
using Npgsql;
using System.Configuration;

namespace InventarioPokemon
{
    public partial class FormMenuLogin : Form
    {
        private readonly SqlConnectManager _gerenciadorDeConexao;
        public FormMenuLogin()
        {
            InitializeComponent();
            _gerenciadorDeConexao = new SqlConnectManager();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTestarConexao_Click(object sender, EventArgs e)
        {
            
        }
    }
}