using InventarioPokemon.Models;
using InventarioPokemon.Services;
using Npgsql;
using System.Configuration;

namespace InventarioPokemon
{
    public partial class FormMenuLogin : Form
    {
        public FormMenuLogin()
        {
            InitializeComponent();
            btnTestarConexao.Click += new EventHandler(btnTestarConexao_Click);

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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
    }
}