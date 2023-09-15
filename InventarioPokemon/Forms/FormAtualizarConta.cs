using InventarioPokemon.Models.UsuarioModels.UsuarioConfigs;

namespace InventarioPokemon.Forms;

public partial class FormAtualizarConta : Form
{
    public FormAtualizarConta()
    {
        InitializeComponent();
    }

    private void btnAtualizar_Click(object sender, EventArgs e)
    {
        string nome = txtNomeAtualizar.Text;
        string email = txtEmailAtualizar.Text;
        string senha = txtSenhaAtualizar.Text;
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}
