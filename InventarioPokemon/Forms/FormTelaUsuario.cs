using InventarioPokemon.Forms;

namespace InventarioPokemon
{
    public partial class FormTelaUsuario : Form
    {
        public FormTelaUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormConfiguracoesConta configuracoesConta = new();

            this.Hide();
            configuracoesConta.Show();
        }

        private void FormTelaUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
