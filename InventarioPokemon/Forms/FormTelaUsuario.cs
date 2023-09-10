using InventarioPokemon.Forms;
using InventarioPokemon.Models.UsuarioModels.UsuarioConfigs;
using InventarioPokemon.Services.BdConexao;

namespace InventarioPokemon
{
    public partial class FormTelaUsuario : Form
    {
        private string _connectionString;
        public int UsuarioID { get; set; }
        public FormTelaUsuario()
        {
            InitializeComponent();
            _connectionString = SqlConnectManager.GetConnectionString();
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {

        }
    }
}
