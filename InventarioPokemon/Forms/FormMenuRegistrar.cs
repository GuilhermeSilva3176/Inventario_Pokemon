using InventarioPokemon.Models.UsuarioLoginERegistrar;
using InventarioPokemon.Services.BdConexao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioPokemon.Forms
{
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
            string nome = txtNomeRegistrar.Text;
            string email = txtEmailRegistrar.Text;
            string senha = txtSenhaRegistrar.Text;

            if (!string.IsNullOrEmpty(nome) && !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(senha))
            {
                try
                {
                    RegistrarConta regisConta = new(linhaDeConexão);

                    bool regisSucesso = regisConta.RegistrarUsuario(nome, email, senha);

                    if (regisSucesso)
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
        }
    }
}
