using InventarioPokemon.Models.UsuarioModels.UsuarioConfigs;
using InventarioPokemon.Services.BdConexao;

namespace InventarioPokemon.Forms;

public partial class FormMenuRegistrar : Form
{
    public FormMenuRegistrar()
    {
        InitializeComponent();
    }

    private void btnRegistrar_Click(object sender, EventArgs e)
    {
        FormMenuLogin formMenuLogin = new();
        string nome = txtNomeRegistrar.Text;
        string email = txtEmailRegistrar.Text;
        string senha = txtSenhaRegistrar.Text;

        if (string.IsNullOrEmpty(nome) && string.IsNullOrEmpty(email) && string.IsNullOrEmpty(senha))
        {
            lblRegistro.Text = "Preencha todos os campos";
            lblRegistro.ForeColor = Color.Red;
        }
        else
        {
            try
            {
                RegistrarConta regisConta = new();
                int regisSucesso = regisConta.RegistrarUsuario(nome, email, senha);

                if (regisSucesso != 0)
                {
                    MessageBox.Show("Registro realizado com sucesso!");
                    this.Close();
                    formMenuLogin.Show();
                }
                else{ MessageBox.Show("Erro ao registrar. Verifique os detalhes da conexão "); }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao conectar ao banco de dados: {ex.Message}");
            }
        }
    }
}
