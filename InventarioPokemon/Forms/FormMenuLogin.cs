using InventarioPokemon.Models;
using InventarioPokemon.Services;
using Npgsql;
using System.Configuration;

namespace InventarioPokemon
{
    public partial class FormMenuLogin : Form
    {
        private ELPSqlConnection _connection;
        private readonly ApiPokemonService _pokeApiService = new();


        public FormMenuLogin()
        {
            InitializeComponent();
            string chaveConexao = ConfigurationManager.ConnectionStrings["MyDatabase"].ConnectionString;
            try
            {
                ELPSqlConnection connection = new(chaveConexao);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"meu cu é teu: {ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}