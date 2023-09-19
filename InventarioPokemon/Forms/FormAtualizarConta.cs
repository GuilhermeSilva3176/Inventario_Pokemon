using InventarioPokemon.Models.UsuarioModels.UsuarioConfigs;

namespace InventarioPokemon.Forms;

public partial class FormAtualizarConta : Form
{
    public int UsuarioID { get; set; }
    public FormAtualizarConta(int usuarioID)
    {
        InitializeComponent();
        UsuarioID = usuarioID;
    }

    private void btnAtualizar_Click(object sender, EventArgs e)
    {
        string nome = txtNomeAtualizar.Text;
        string email = txtEmailAtualizar.Text;
        string senha = txtSenhaAtualizar.Text;

        int id = UsuarioID;

        try
        {
            AtualizarConta atualizarConta = new();
            int resultadoAtualizacao = atualizarConta.AttConta(id, nome, email, senha);

            if (resultadoAtualizacao > 0)
            {
                var formTelaUsuario = Application.OpenForms.OfType<FormTelaUsuario>().FirstOrDefault();
                if (formTelaUsuario != null)
                {
                    formTelaUsuario.AtualizarNomeUsuario(nome,email);
                }
                this.Close();
            }
            else if (resultadoAtualizacao < 0)
            {
                lblResultado.Text = "Conta não atualizada ou algo aconteceu";
            }
        }
        catch (Exception ex)
        {
            lblResultado.Text = $"Erro: {ex.Message}";
        }

    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}
