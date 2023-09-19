using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace InventarioPokemon.Forms;

public partial class FormTelaUsuarioPokemon : Form
{
    public int Id {  get; set; }
    public string Senha {  get; set; }
    public string Email { get; set; }
    public FormTelaUsuarioPokemon(int id,string email,string senha)
    {
        InitializeComponent();
        Id = id;
        Senha = senha;
        Email = email;
    }

    private void btnFormTelaUsuario_Click(object sender, EventArgs e)
    {
        FormTelaUsuario fTelaUsuario = new(Email, Senha)
        {
            UsuarioID = Id
        };
        fTelaUsuario.Show();
    }
}
