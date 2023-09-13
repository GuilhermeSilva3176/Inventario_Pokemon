using InventarioPokemon.Models.UsuarioModels;

namespace InventarioPokemon.Services.ServicoDeAutenticacao;

public class AutenticacaoService
{
    public int AutenticarUsuario(string email, string senha)
    {
        try
        {
            LogarConta idConta = new();
            int id;
            id = idConta.LogarUsuario(email, senha);
            return id;

        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao conectar ao banco de dados: {ex.Message}");
            return -1;
        }
    }
}