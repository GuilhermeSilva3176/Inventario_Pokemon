namespace InventarioPokemon.Forms;

public partial class FormConfiguracoesConta : Form
{
    public FormConfiguracoesConta()
    {
        InitializeComponent();
    }

    private void FormConfiguracoesConta_Load(object sender, EventArgs e)
    {

    }

    private void btnVoltar_Click(object sender, EventArgs e)
    {
        FormTelaUsuario formTelaUsuario = new FormTelaUsuario();
        this.Close();
        formTelaUsuario.Show();
    }
}
