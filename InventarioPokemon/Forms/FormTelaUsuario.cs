using InventarioPokemon.Forms;
using InventarioPokemon.Models.UsuarioModels;
using InventarioPokemon.Models.UsuarioModels.UsuarioConfigs;
using InventarioPokemon.Services.BdConexao;

namespace InventarioPokemon
{
    public partial class FormTelaUsuario : Form
    {
        public int UsuarioID { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public FormTelaUsuario()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int idUsuario = UsuarioID;
            try
            {
                DeletarConta deletarConta = new();
                int resultado = deletarConta.ExcluirUsuarioPorID(idUsuario);

                if (resultado == 0)
                {
                    FormMenuLogin formMenuLogin = new();
                    MessageBox.Show("Conta excluida com sucesso!");
                    this.Close();
                    formMenuLogin.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Erro ao excluir a conta");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao conectar ao banco de dados: {ex.Message}");
            }
        }
    }
}
