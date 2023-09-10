using InventarioPokemon.Models.UsuarioModels;

namespace InventarioPokemon.Services.ServicoDeAutenticacao;

public class AutenticacaoService
{
    public int AutenticarUsuario(string email, string senha, Form form)
    {
        if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(senha))
        {
            ExibirErro(form, "Preencha os campos", Color.Red);
            return -1;
        }

        try
        {
            LogarConta logarConta = new();
            int usuarioId = logarConta.LogarUsuario(email, senha);
            
            if (usuarioId > 0)
            {
                return 0;
            }
            else if (usuarioId == -1)
            {
                ExibirErro(form, "Email ou Senha incorretos", Color.Red);
                return -1;
            }
            else
            {
                ExibirErro(form, "Erro durante a autenticação.", Color.Red);
                return -1;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao conectar ao banco de dados: {ex.Message}");
            return -1;
        }
    }

    private void ExibirErro(Form form, string mensagem, Color cor)
    {
        Label lblLogar = form.Controls.Find("lblLogar", true).FirstOrDefault() as Label;
        lblLogar.Text = mensagem;
        lblLogar.ForeColor = cor;
    }
}