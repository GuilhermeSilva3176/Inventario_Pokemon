
using InventarioPokemon.Forms;
using InventarioPokemon.Models.UsuarioModels.UsuarioConfigs;


namespace InventarioPokemon
{
    public partial class FormTelaUsuario : Form
    {
        public int UsuarioID { get; set; }

        public FormTelaUsuario(string email, string senha)
        {
            InitializeComponent();

            NomeConta nomeARetornar = new(email, senha);
            string mostrarNome = nomeARetornar.RetornaNome();
            lblUsuario.Text = mostrarNome;
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

        private void btnFormAtualizar_Click(object sender, EventArgs e)
        {
            FormAtualizarConta fAtualizarConta = new();
            fAtualizarConta.Show();
        }
    }
}
