using InventarioPokemon.Models.UsuarioModels.UsuarioConfigs;
using InventarioPokemon.Services.BdConexao;

namespace InventarioPokemon.Forms;

public partial class FormMenuRegistrar : Form
{
    private string linhaDeConexão;
    public FormMenuRegistrar()
    {
        InitializeComponent();
        linhaDeConexão = SqlConnectManager.GetConnectionString();
    }

    private void btnRegistrar_Click(object sender, EventArgs e)
    {
        FormMenuLogin formMenuLogin = new FormMenuLogin();
        string nome = txtNomeRegistrar.Text;
        string email = txtEmailRegistrar.Text;
        string senha = txtSenhaRegistrar.Text;

        if (!string.IsNullOrEmpty(nome) && !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(senha))
        {
            try
            {
                RegistrarConta regisConta = new();

                int regisSucesso = regisConta.RegistrarUsuario(nome, email, senha);

                if (regisSucesso == 0)
                {
                    MessageBox.Show("Registro realizado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro ao registrar. Verifique os detalhes da conexão ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao conectar ao banco de dados: {ex.Message}");
            }
        }
        else
        {
            lblRegistro.Text = "Preencha todos os campos";
            lblRegistro.ForeColor = Color.Red;
        }
        this.Close();
        formMenuLogin.Show();
    }

    private void FormMenuRegistrar_Load(object sender, EventArgs e)
    {

    }
}
